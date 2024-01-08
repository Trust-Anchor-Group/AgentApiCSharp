using Neuron.Agent.Api;
using Neuron.Agent.Client;
using Neuron.Agent.Model;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Linq;

namespace WalletExample
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("1. Create Account");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();
                try
                {
                    switch (choice)
                    {
                        //Create an account and go to the logged in menu
                        case "1":
                            await CreateAccount();
                            await LoggedInMenu();
                            break;
                        //Login and go to the logged in menu
                        case "2":
                            await Login();
                            await LoggedInMenu();
                            break;
                        //Exit the program
                        case "3":
                            exit = true;
                            break;
                    }
                }
                catch (ApiException e)
                {
                    Console.WriteLine("An error occured with an Api call");
                    Console.WriteLine("HTTP code: " + e.ErrorCode);
                    Console.WriteLine("Message: " + e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("An error occured: " + e.Message);
                }
            }
        }

        static async Task LoggedInMenu()
        {
            //Check if the user has an approved legal identity
            string? id = await CheckLegalIdentityStatus();
            while(id == null)
            {
                id = await ApplyForLegalId();
                if(id == null)
                {
                    Console.WriteLine("Something went wrong");
                    Console.WriteLine("Press ENTER to retry");
                    Console.ReadLine();
                }
            }

            //Wait for the identity to be processed
            await WaitForLegalIdentityApplication(id);

            Console.WriteLine("1. Get wallet balance");
            Console.WriteLine("2. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    WalletApi api = new WalletApi(GlobalConfig.instance);
                    GetBalanceResponse response = await api.GetBalanceAsync(new object());
                    Console.WriteLine("Balance: " + response.Amount + " " + response.Currency);
                    break;
                case "2":
                    return;
            }
        }

        static async Task<string?> CheckLegalIdentityStatus()
        {
            //request 10 identities connected to the account
            LegalApi api = new LegalApi(GlobalConfig.instance);
            IdentitiesResponseJSON response = await api.GetIdentitiesAsync(new GetIdentitiesBody(0, 10));

            //check status of all identities
            foreach (var identity in response.Identities)
            {
                //if the identity is still in the created state, return it
                if (identity.Status.State == "Created")
                {
                    Console.WriteLine("Identity application not processed yet");
                    return identity.Id;
                }

                //if the identity is in the approved state, return it
                if (identity.Status.State == "Approved")
                {
                    Console.WriteLine("Found approved legal identity");
                    return identity.Id;
                }
            }

            return null;
        }


        /// <summary>
        /// Waits for the legal identity application to be processed if it is in the created state
        /// </summary>
        /// <param name="id">The id property of the legal id</param>
        static async Task WaitForLegalIdentityApplication(string id)
        {
            LegalApi api = new LegalApi(GlobalConfig.instance);
            while (true)
            {
                //request the identity
                IdentityResponseJSON response = await api.GetIdentityAsync(new GetIdentityBody(id));

                //if the identity is in the approved state, return
                if (response.Identity.Status.State == "Approved")
                {
                    Console.WriteLine("Identity application approved");
                    return;
                }

                //if the identity is in the rejected state, return
                if (response.Identity.Status.State == "Rejected")
                {
                    Console.WriteLine("Identity application rejected");
                    Console.WriteLine("Press ENTER to retry");
                    Console.ReadLine();
                    return;
                }

                //if the identity is in the created state, wait for it to be processed
                Console.WriteLine("Waiting for identity application to be processed");

                //wait 5 seconds before checking again
                await Task.Delay(5000);
            }
        }

        /// <summary>
        /// Applies for a legal identity on the account
        /// </summary>
        /// <returns>The id of the legal identity or null if it fails</returns>
        static async Task<string?> ApplyForLegalId()
        {
            //First we need to create a key associated with the legal identity
            CryptoApi cryptoApi = new CryptoApi(GlobalConfig.instance);
            AlgorithmsResult response = await cryptoApi.GetAlgorithmsAsync(new object());

            //Sort algorithms based on safety and secuirity
            List<Algorithm> sortedAlgorithms = response.Algorithms.OrderByDescending(item => item.Safe)
                                   .ThenByDescending(item => item.SecurityStrength)
                                   .ToList();
            if (sortedAlgorithms.Count == 0) //This should never happend
            {
                throw new ApiException(0, "Neuron does not support any algorithms for keys");
            }

            //Select the most fit algorithm
            var selectedAlgorithm = sortedAlgorithms.First();

            Console.WriteLine("Creating key for legal identity");
            Console.WriteLine("Selected algorithm for key: " + selectedAlgorithm.LocalName);
            Console.WriteLine("Enter a password for the key:");
            string keySecret = Console.ReadLine();
            Console.WriteLine("Enter the password for the account:");
            string accountSecret = Console.ReadLine();

            string nonce = Utils.GenerateNonce();

            // Create the key signature
            string s1 = $"{GlobalConfig.instance.Username}:{cryptoApi.Configuration.BasePath.Replace("https://", "").Replace("http://", "")}:{selectedAlgorithm.LocalName}:{selectedAlgorithm.VarNamespace}:{"LegalIdentityKey"}";
            string keySignature = Utils.Sign(s1, keySecret);

            // Create the request signature
            string s2 = $"{s1}:{keySignature}:{nonce}";
            string requestSignature = Utils.Sign(s2, accountSecret);

            // Complete the request 
            CreateKeyBody createKeybody = new CreateKeyBody(selectedAlgorithm.LocalName, selectedAlgorithm.VarNamespace, "LegalIdentityKey", nonce, keySignature, requestSignature);
            Console.WriteLine(createKeybody.ToJson());
            Stored key = await cryptoApi.CreateKeyAsync(createKeybody);

            // Now we need to apply for the legal identity

            LegalApi legalApi = new LegalApi(GlobalConfig.instance);
            
            //Get the required properties for the legal identity
            GetApplicationAttributesResponse attributesResponse = await legalApi.GetApplicationAttributesAsync(new object());
            List<ApplyIdBodyPropertiesInner> properties = new List<ApplyIdBodyPropertiesInner>();
            foreach (var item in attributesResponse.Required)
            {
                Console.WriteLine("Please enter " + item + ":");
                properties.Add(new ApplyIdBodyPropertiesInner(item, Console.ReadLine()));
            }

            //Create the request signature
            nonce = Utils.GenerateNonce();
            s2 = $"{s1}:{keySignature}:{nonce}";
            foreach (var item in properties)
            {
                s2 += $":{item.Name}:{item.Value}";
            }
            requestSignature = Utils.Sign(s2, accountSecret);

            //Complete the request
            var applyIdBody = new ApplyIdBody("LegalIdentityKey", nonce, keySignature, requestSignature, properties);
            var applyIdResponse = await legalApi.ApplyIdAsync(applyIdBody);

            return applyIdResponse.Identity.Id;

        }

        /// <summary>
        /// Handles the account creation process
        /// </summary>
        static async Task CreateAccount()
        {
            Console.WriteLine("Enter API key:");
            string apiKey = Console.ReadLine();
            Console.WriteLine("Enter API secret:");
            string apiSecret = Console.ReadLine();
            Console.WriteLine("Enter username:");
            string username = Console.ReadLine();
            Console.WriteLine("Enter password:");
            string password = Console.ReadLine();
            Console.WriteLine("Enter email:");
            string email = Console.ReadLine();

            var response = await AccountActions.CreateAccount(apiKey, apiSecret, username, password, email);
            GlobalConfig.instance.AccessToken = response.Jwt; // Set the JWT token for authentication
            Console.WriteLine("Account created successfully");

            Console.WriteLine(GlobalConfig.instance.AccessToken);

            Console.WriteLine("Enter the code sent to " + email);
            string code = Console.ReadLine();
            await AccountActions.VerifyEMail(email, code);
            Console.WriteLine("Email verified successfully");
            GlobalConfig.instance.Username = username;
        }

        /// <summary>
        /// Handles the login process
        /// </summary>
        static async Task Login()
        {
            Console.WriteLine("Enter username:");
            string username = Console.ReadLine();
            Console.WriteLine("Enter password:");
            string password = Console.ReadLine();

            var response = await AccountActions.Login(username, password);
            //GlobalConfig.instance.DefaultHeaders.Add("Authorization", "Bearer " + response.Jwt); // Set the JWT token for authentication
            GlobalConfig.instance.AccessToken = response.Jwt; // Switch to this after fixing the Openapi specification authentication mishaps hotfix
            //Here we use the username variable that is used for WWW-Authenticate to store the username
            GlobalConfig.instance.Username = username; //Store Username for later use

            Console.WriteLine("Logged in successfully");
        }
    }
}
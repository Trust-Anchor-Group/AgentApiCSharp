﻿using Neuron.Agent.Api;
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
            await EntryMenu();
        }

        /// <summary>
        /// Displays and handles the entry point menu
        /// </summary>
        static async Task EntryMenu()
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
                    Console.WriteLine("An error occured: " + e.Message);
                }
            }
        }

        static async Task LoggedInMenu()
        {
            try
            {
                await CheckLegalIdentityStatus();
                Console.WriteLine("1. Get wallet balance");
                Console.WriteLine("2. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        await GetWalletBalance();
                        break;
                    case "2":
                        break;
                }
            }
            catch (ApiException e)
            {
                Console.WriteLine("An error occured: " + e.Message);
            }
        }


        static async Task GetWalletBalance()
        {
            WalletApi api = new WalletApi(GlobalConfig.instance);
            GetBalanceResponse response = await api.GetBalanceAsync(new object());
            Console.WriteLine("Balance: " + response.Amount + " " + response.Currency);
        }

        static async Task CheckLegalIdentityStatus()
        {
            //request all identities connected to the account
            LegalApi api = new LegalApi(GlobalConfig.instance);
            IdentitiesResponseJSON response = await api.GetIdentitiesAsync(new GetIdentitiesBody(0, 10));

            int numberOfApprovedIdentities = 0;

            //check status of all identities
            foreach (var identity in response.Identities)
            {
                //if the identity is still in the created state, wait for it to be processed
                if (identity.Status.State == "Created")
                {
                    Console.WriteLine("Identity application not processed yet");
                    await WaitForLegalIdentityApplication(identity.Id);
                    await CheckLegalIdentityStatus(); //restart the process
                    return;
                }

                //if the identity is in the approved state, return
                if (identity.Status.State == "Approved")
                {
                    numberOfApprovedIdentities++;
                }
            }

            if (numberOfApprovedIdentities == 0)
            {
                Console.WriteLine("No approved identities found");
                Console.WriteLine("Applying for legal identity");
                await ApplyForLegalId();
                await CheckLegalIdentityStatus(); //restart the process

            }
            else
            {
                Console.WriteLine("Approved identity found");
            }
        }

        static async Task WaitForLegalIdentityApplication(string id)
        {
            try
            {
                Console.WriteLine("Waiting for identity application to be processed");
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

                    //wait 5 seconds before checking again
                    await Task.Delay(5000);
                }
            }
            catch (ApiException ex)
            {
                Console.WriteLine("An error occured: " + ex.Message);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        static async Task ApplyForLegalId()
        {
            CryptoApi cryptoApi = new CryptoApi(GlobalConfig.instance);
            var response = await cryptoApi.GetAlgorithmsAsync(new object());
            Console.WriteLine("Available algorithms: " + response.Algorithms.Count);
            //Sort algorithms based on safety and secuirity
            var sortedAlgorithms = response.Algorithms.OrderByDescending(item => item.Safe)
                                   .ThenByDescending(item => item.SecurityStrength)
                                   .ToList();
            //Select the most fit algorithm
            var selectedAlgorithm = sortedAlgorithms.First();

            if (selectedAlgorithm == null) //This should never happend
            {
                Console.WriteLine("Neuron does not support any algorithms for keys");
                return;
            }
            Console.WriteLine("Selected algorithm for key: " + selectedAlgorithm.LocalName);

            Console.WriteLine("Generating key");

            Console.WriteLine("Enter a password for the key:");
            string keySecret = Console.ReadLine();
            Console.WriteLine("Enter the password for the account:");
            string accountSecret = Console.ReadLine();

            string nonce = Utils.GenerateNonce();

            // Step 1: Concatenate the strings
            string s1 = $"{GlobalConfig.instance.Username}:{cryptoApi.Configuration.BasePath.Replace("https://", "").Replace("http://", "")}:{selectedAlgorithm.LocalName}:{selectedAlgorithm.VarNamespace}:{"LegalIdentityKey"}";
            Console.WriteLine("Step 1: " + s1);
            string keySignature = Utils.Sign(s1, keySecret);

            string s2 = $"{s1}:{keySignature}:{nonce}";
            string requestSignature = Utils.Sign(s2, accountSecret);


            var body = new CreateKeyBody(selectedAlgorithm.LocalName, selectedAlgorithm.VarNamespace, "LegalIdentityKey", nonce, keySignature, requestSignature);
            Console.WriteLine(body.ToJson());
            var key = await cryptoApi.CreateKeyAsync(body);


            LegalApi legalApi = new LegalApi(GlobalConfig.instance);
            var test = await legalApi.GetApplicationAttributesAsync(new object());


            List<ApplyIdBodyPropertiesInner> properties = new List<ApplyIdBodyPropertiesInner>();
            foreach (var item in test.Required)
            {
                Console.WriteLine("Please enter " + item + ":");
                properties.Add(new ApplyIdBodyPropertiesInner(item, Console.ReadLine()));
            }

            nonce = Utils.GenerateNonce();
            s2 = $"{s1}:{keySignature}:{nonce}";

            foreach (var item in properties)
            {
                s2 += $":{item.Name}:{item.Value}";
            }

            requestSignature = Utils.Sign(s2, accountSecret);

            var applyIdBody = new ApplyIdBody("LegalIdentityKey", nonce, keySignature, requestSignature, properties);
            var applyIdResponse = await legalApi.ApplyIdAsync(applyIdBody);

            await WaitForLegalIdentityApplication(applyIdResponse.Identity.Id);

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
            GlobalConfig.instance.AccessToken = response.Jwt; // Set the JWT token for authentication
            GlobalConfig.instance.Username = username;

            Console.WriteLine("Logged in successfully");
        }
    }
}
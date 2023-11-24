// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
using Tag.Networking.Agent.Api;
using Tag.Networking.Agent.Client;
using Tag.Networking.Agent.Model;


class Program
{
    // Generates a nonce of a given byte length
    public static string GenerateNonce(int byteLength)
    {
        byte[] data = new byte[byteLength];

        using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
        {
            rng.GetBytes(data);
        }

        // Convert the byte array to a Base64 string
        return Convert.ToBase64String(data);
    }

    // Generates a signature for authentication
    public static string GenerateSignature(string pUserName, string host, string pNonce, string password)
    {
        // Concatenate the strings
        string s = $"{pUserName}:{host}:{pNonce}";

        // UTF-8 encode the password and the concatenated string
        byte[] key = Encoding.UTF8.GetBytes(password);
        byte[] data = Encoding.UTF8.GetBytes(s);

        // Calculate the HMAC-SHA256 signature
        using (HMACSHA256 hmac = new HMACSHA256(key))
        {
            byte[] signatureBytes = hmac.ComputeHash(data);

            // Base64-encode the signature
            return Convert.ToBase64String(signatureBytes);
        }
    }

    public static void Main()
    {
        string domain = "neuron.saunter.tech";
        string basePath = "https://neuron.saunter.tech";

        Configuration config = new Configuration();
        config.BasePath = basePath;
        // API configuration and domain information



        // Attempt to log in

        try
        {
            // create an instance of the account API class, 
            var accountInstance = new AccountApi(config);

            // Retrieve and display domain information
            DomainInfoResponse info = accountInstance.GetDomainInfo();
            Console.WriteLine(info);


            // User input for credentials
            Console.Write("Enter username: ");
            string username = Console.ReadLine();
            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            var nonce = GenerateNonce(32);
            var sign = GenerateSignature(username, domain, nonce, password);


            // Create a login request
            LoginResponse loggedIn = accountInstance.Login(new LoginBody(username, nonce, sign, 3600));
            Console.WriteLine("Login successful!");

            // Set up API instance for the next call
            config.DefaultHeaders.Add("Authorization", $"Bearer {loggedIn.Jwt}");
            var legalInstance = new LegalApi(config);

            //You can add the Authorization header to existing instances aswell
            //legalInstance.Configuration.DefaultHeaders.Add("Authorization", $"Bearer {loggedIn.Jwt}");


            // Fetch and display legal identities connected to the current account
            var getIdentitiesBody = new GetIdentitiesBody(0, 2);
            var response = legalInstance.GetIdentities(getIdentitiesBody);
            foreach (var identity in response.Identities)
            {
                Console.WriteLine(identity);
            }

        }
        catch (ApiException e)
        {
            Debug.Print("Exception when calling AccountApi.CreateAccount: " + e.Message);
            Debug.Print("Status Code: " + e.ErrorCode);
            Debug.Print(e.StackTrace);
        }
    }
}
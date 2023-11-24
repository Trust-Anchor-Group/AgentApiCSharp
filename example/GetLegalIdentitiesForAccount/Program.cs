// See https://aka.ms/new-console-template for more information

using System;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
using TAG.Agent.Api;
using TAG.Agent.Client;
using TAG.Agent.Model;

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
        // API configuration and domain information
        string domain = "neuron.saunter.tech";
        string basePath = "https://neuron.saunter.tech";
        Configuration.Default.BasePath = basePath;


        // Attempt to log in

        try
        {
            // create an instance of the account API class, per default is uses the Configuration.Default settings
            var accountInstance = new AccountApi();
            // You can change the instance configuration using the following:
            // accountInstance.Configuration.BasePath = "http://localhost:8080"; etc...

            // Retrieve and display domain information
            DomainInfo info = accountInstance.GetDomainInfo();
            Console.WriteLine(info);


            // User input for credentials
            Console.Write("Enter username: ");
            string username = Console.ReadLine();
            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            var nonce = GenerateNonce(32);
            var sign = GenerateSignature(username, domain, nonce, password);


            // Create a login request
            var loginBody = new Login(username, nonce, sign, 3600);
            LoggedIn loggedIn = accountInstance.Login(loginBody);

            // add the JWT token to the configuration
            Configuration.Default.AddDefaultHeader("Authorization", "Bearer " + loggedIn.Jwt);

            Console.WriteLine("Login successful!");

            // Set up API instance to access the Legal resource
            var legalInstance = new LegalApi();

            // Fetch and display a legal identitity for the account (if one exists)
            var response = legalInstance.GetIdentities(new GetIdentities(0, 1));
            if (response.Identities.Count == 0)
            {
                Console.WriteLine("No legal identity found for this account.");
            }
            else
            {
                Console.WriteLine("Legal identity:");
                foreach (var pair in response.Identities[0])
                {
                    Console.WriteLine($"  {pair.Key}: {pair.Value}");
                }
            }

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

using TAG.Networking.Agent.Api;
using TAG.Networking.Agent.Client;
using System;
using System.Threading.Tasks;
using TAG.Networking.Agent.Model;
using System.Security.Cryptography;
using System.Text;

namespace AuthenticationExample
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // Set up API configuration
            Configuration config = new Configuration();
            config.BasePath = "https://neuron.saunter.tech"; // Replace with actual API base path

            // Initialize the API client
            AccountApi accountApi = new AccountApi(config);

            try
            {
                // User input for credentials
                Console.WriteLine("Enter username:");
                string username = Console.ReadLine();
                Console.WriteLine("Enter password:");
                string password = Console.ReadLine();

                // Authentication process
                LoginResponse response = await AuthenticateUser(accountApi, username, password);

                // the Agent API uses JWT (JSON Web Token) authentication
                // For future requests we add the JWT as bearer token in the Authorization header.
                config.DefaultHeaders.Add("Authorization", "Bearer " + response.Jwt);
                //Merge Config changes in order to reuse the AccountApi Instance
                accountApi.Configuration = Configuration.MergeConfigurations(config, accountApi.Configuration);

                Console.WriteLine("Successfully authenticated user!");
               
                //calculate response.Expires to seconds left
                int secondsLeft = (int)(response.Expires - DateTimeOffset.UtcNow.ToUnixTimeSeconds());
                Console.WriteLine("JWT expires in: " + secondsLeft + " seconds");
            }
            catch (ApiException e)
            {
                Console.WriteLine("Authentication failed.");
                Console.WriteLine("Error: " + e.Message);
            }
        }

        private static async Task<LoginResponse> AuthenticateUser(AccountApi accountApi, string username, string password)
        {
            //In order to Authenticate a user we have to create a signature for the request
            //The documentation for this can be found at https://lab.tagroot.io/Documentation/Neuron/Agent/Account/Login.md

            //Generate a nonce, for this example this is not garantueed to be unique
            //For this example it is has sufficient entropy to be valid
            byte[] rawNonce = new byte[32];
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(rawNonce);
            }
            string nonce = Convert.ToBase64String(rawNonce); // Convert the byte array to a Base64 string
            string host = accountApi.Configuration.BasePath.Replace("https://", "").Replace("http://", "");
            string s = $"{username}:{host}:{nonce}";

            // UTF-8 encode the password and the concatenated string
            // The password will be used as the encryption key
            // the concatenated string is the data to be encrypted
            byte[] key = Encoding.UTF8.GetBytes(password);
            byte[] data = Encoding.UTF8.GetBytes(s);

            string signature;
            // Calculate the HMAC-SHA256 signature
            using (HMACSHA256 hmac = new HMACSHA256(key))
            {
                byte[] signatureBytes = hmac.ComputeHash(data);

                // Base64-encode the signature
                signature = Convert.ToBase64String(signatureBytes);
            }

            int expiresInSeconds = 360; 

            // Create the request
            LoginBody body = new LoginBody(username, nonce, signature, expiresInSeconds);
            return await accountApi.LoginAsync(body);
        }
    }
}

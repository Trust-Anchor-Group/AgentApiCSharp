using System.Security.Cryptography;
using System.Text;
using TAG.Networking.Agent.Api;
using TAG.Networking.Agent.Client;
using TAG.Networking.Agent.Model;

namespace LegalExample
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost"; //Here you can change the the base path (domain) of the api


            try
            {
                //login
                LoginResponse loginResponse = await Login(config);
                config.DefaultHeaders.Add("Authorization", "Bearer " + loginResponse.Jwt);

                LegalApi legalApi = new LegalApi(config);
                IdentitiesResponseJSON response = await legalApi.GetIdentitiesAsync(new GetIdentitiesBody(0, 1));

                foreach (IdentityJson identity in response.Identities)
                {
                    Console.WriteLine(identity);
                    foreach (IdentityJsonPropertyInner identityJsonIdentity in identity.Property)
                    {

                    }
                }
            }
            catch (ApiException e)
            {
                //If something went wrong with the request an ApiException will be thrown
                Console.WriteLine(e.Message);
                Console.WriteLine("HTTP code: :" + e.ErrorCode);
            }

        }

        static string GenerateNonce()
        {
            byte[] data = new byte[32];

            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(data);
            }

            // Convert the byte array to a Base64 string
            return Convert.ToBase64String(data);
        }

        static async Task<LoginResponse> Login(Configuration config)
        {
            // Input the required information
            Console.WriteLine("Enter username:");
            string username = Console.ReadLine();
            Console.WriteLine("Enter password:");
            string password = Console.ReadLine();

            //Create accountApi instance based on config
            AccountApi accountApi = new AccountApi(config);

            //Generate a nonce
            string nonce = GenerateNonce();

            //Generate client signature for the request
            string host = accountApi.Configuration.BasePath.Replace("https://", "").Replace("http://", "");
            string s = $"{username}:{host}:{nonce}";

            // UTF-8 encode the password and the concatenated string
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

            // Create the request
            LoginBody body = new LoginBody(username, nonce, signature, 360);
            LoginResponse response = await accountApi.LoginAsync(body);
            return response;
        }
    }
}
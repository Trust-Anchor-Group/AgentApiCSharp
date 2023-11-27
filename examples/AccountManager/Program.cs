using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
using Tag.Networking.Agent.Api;
using Tag.Networking.Agent.Client;
using Tag.Networking.Agent.Model;

namespace AccountManager
{
    internal class Program
    {
        static string domain = "localhost";
        static string basePath = "http://localhost";
        static Configuration config = new Configuration();
        static bool isLoggedIn = false;


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
        public static string GenerateLoginSignature(string username, string host, string nonce, string password)
        {
            // Concatenate the strings
            string s = $"{username}:{host}:{nonce}";

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

        public static string GenerateCreateSignature(string username, string host, string mail, string password, string apiKey, string apiSecret, string nonce)
        {
            // Concatenate the strings
            string s = $"{username}:{host}:{mail}:{password}:{apiKey}:{nonce}";

            // UTF-8 encode the password and the concatenated string
            byte[] key = Encoding.UTF8.GetBytes(apiSecret);
            byte[] data = Encoding.UTF8.GetBytes(s);

            // Calculate the HMAC-SHA256 signature
            using (HMACSHA256 hmac = new HMACSHA256(key))
            {
                byte[] signatureBytes = hmac.ComputeHash(data);

                // Base64-encode the signature
                return Convert.ToBase64String(signatureBytes);
            }
        }

        static void CreateAccount()
        {
            Console.WriteLine("Enter API key:");
            string apikey = Console.ReadLine();
            Console.WriteLine("Enter API secret:");
            string apisecret = Console.ReadLine();
            Console.WriteLine("Enter username:");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter password:");
            string password = Console.ReadLine();
            Console.WriteLine("Enter email:");
            string email = Console.ReadLine();

            var apiInstance = new AccountApi(config);
            string nonce = GenerateNonce(32);
            var createAccountBody = new CreateAccountBody(userName, email, password, apikey, nonce, GenerateCreateSignature(userName, domain, email, password, apikey, apisecret, nonce));

            try
            {
                // Create Account
                CreateAccountResponse result = apiInstance.CreateAccount(createAccountBody);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AccountApi.CreateAccount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }

        static void Login()
        {
            Console.WriteLine("Enter username:");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter password:");
            string password = Console.ReadLine();

            var apiInstance = new AccountApi(config);
            string nonce = GenerateNonce(32);
            var loginBody = new LoginBody(userName, nonce, GenerateLoginSignature(userName, domain, nonce, password), 3600);

            try
            {
                // Login
                LoginResponse result = apiInstance.Login(loginBody);
                Debug.WriteLine(result);
                isLoggedIn = true;
                config.DefaultHeaders.Add("Authorization", $"Bearer {result.Jwt}");
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AccountApi.Login: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }

        static void Logout()
        {

        }


        static void Main(string[] args)
        {
            config.BasePath = basePath;


            bool exit = false;
            while (!exit)
            {
                if (!isLoggedIn)
                {
                    Console.WriteLine("1. Create an account");
                    Console.WriteLine("2. Login");
                    Console.WriteLine("3. Exit");
                    Console.Write("Enter your choice: ");

                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            CreateAccount();
                            break;
                        case "2":
                            Login();
                            break;
                        // ... other cases ...
                        case "3":
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Invalid choice, please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("1. Logout");
                    Console.WriteLine("2. Exit");
                    Console.Write("Enter your choice: ");

                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            Logout();
                            break;
                        case "2":
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Invalid choice, please try again.");
                            break;
                    }
                }

            }
        }
    }
}
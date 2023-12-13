using TAG.Networking.Agent.Api;
using TAG.Networking.Agent.Client;
using TAG.Networking.Agent.Model;

namespace AccountApiExample
{
    internal class Program
    {


        static async Task Main(string[] args)
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost"; //Here you can change the the base path (domain) of the api

            //Create accountApi instance based on config
            AccountApi accountApi = new AccountApi(config);

            bool isLoggedIn = false;
            bool exit = false;
            while (!exit)
            {
                if (!isLoggedIn)
                {
                    Console.WriteLine("1. Create Account");
                    Console.WriteLine("2. Login");
                    Console.WriteLine("3. Exit");
                    Console.Write("Enter your choice: ");
                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            try
                            {
                                // Input the required information
                                Console.WriteLine("Enter API key:");
                                string apiKey = Console.ReadLine();
                                Console.WriteLine("Enter API secret:");
                                string apiSecret = Console.ReadLine();
                                Console.WriteLine("Enter username:");
                                string username = Console.ReadLine();
                                Console.WriteLine("Enter password:");
                                string password = Console.ReadLine();
                                Console.WriteLine("Enter email:");
                                string mail = Console.ReadLine();

                                //Send the request
                                CreateAccountResponse response = await AccountHelper.CreateAccount(accountApi, apiKey, apiSecret, username, password, mail);

                                //Add the bearer token to the instance
                                accountApi.Configuration.DefaultHeaders.Add("Authorization", "Bearer " + response.Jwt);

                                //Check if accounts needs to be verified
                                if (!response.Enabled)
                                {
                                    Console.WriteLine("Enter code sent to " + mail + ":");
                                    string code = Console.ReadLine();
                                    await accountApi.VerifyEMailAsync(new VerifyEMailBody(mail, code));
                                }

                                Console.WriteLine("Successfully created account");
                                Console.WriteLine("jwt: " + response.Jwt);
                                //Calculate the expiration date of the jwt
                                DateTime expireDate = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
                                expireDate = expireDate.AddSeconds(response.Expires).ToLocalTime();
                                Console.WriteLine("jwt expires: " + expireDate);

                                //Update global configuration
                                config.DefaultHeaders.Add("Authorization", "Bearer " + response.Jwt);
                                accountApi.Configuration = Configuration.MergeConfigurations(config, accountApi.Configuration);
                                isLoggedIn = true;
                            }
                            catch (ApiException e)
                            {
                                Console.WriteLine("Failed to create account");
                                Console.WriteLine("Status code: " + e.ErrorCode);
                                Console.WriteLine(e.Message);
                            }
                            break;
                        case "2":
                            try
                            {
                                // Input the required information
                                Console.WriteLine("Enter username:");
                                string username = Console.ReadLine();
                                Console.WriteLine("Enter password:");
                                string password = Console.ReadLine();

                                //Send the request
                                LoginResponse response = await AccountHelper.Login(accountApi, username, password);

                                Console.WriteLine("Successfully logged in");
                                Console.WriteLine("jwt: " + response.Jwt);
                                //Calculate the expiration date of the jwt
                                DateTime expireDate = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
                                expireDate = expireDate.AddSeconds(response.Expires).ToLocalTime();
                                Console.WriteLine("jwt expires: " + expireDate);

                                //Update global configuration
                                config.AccessToken = response.Jwt;
                                accountApi.Configuration = Configuration.MergeConfigurations(config, accountApi.Configuration);
                                isLoggedIn = true;
                            }
                            catch (ApiException e)
                            {
                                Console.WriteLine("Failed to login to account");
                                Console.WriteLine("Status code: " + e.ErrorCode);
                                Console.WriteLine(e.Message);
                            }
                            break;
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
                    Console.WriteLine("2. Refresh Token");
                    Console.WriteLine("3. Exit");
                    Console.Write("Enter your choice: ");
                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            //Clear authorization header from configuration
                            config.DefaultHeaders.Remove("Authorization");
                            accountApi.Configuration = Configuration.MergeConfigurations(config, accountApi.Configuration);
                            isLoggedIn = false;
                            break;
                        case "2":
                            // refresh the jwt
                            LoginResponse response = await accountApi.RefreshAsync(new RefreshBody(360));
                            config.DefaultHeaders.Remove("Authorization");
                            config.DefaultHeaders.Add("Authorization", "Bearer " + response.Jwt);
                            accountApi.Configuration = Configuration.MergeConfigurations(config, accountApi.Configuration);

                            //Print results
                            Console.WriteLine("Successfully refreshed token");
                            //calculate new expiry date
                            DateTime expireDate = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
                            expireDate = expireDate.AddSeconds(response.Expires).ToLocalTime();
                            Console.WriteLine("jwt expires: " + expireDate);
                            break;
                        case "3":
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
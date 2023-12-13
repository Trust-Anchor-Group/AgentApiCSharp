﻿using TAG.Networking.Agent.Client;
using TAG.Networking.Agent.Model;

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

            Console.WriteLine("Logged in successfully");
        }
    }
}
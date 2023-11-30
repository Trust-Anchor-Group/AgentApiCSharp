using AccountApiExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TAG.Networking.Agent.Api;
using TAG.Networking.Agent.Client;
using TAG.Networking.Agent.Model;

public static class AccountHelper
{
    /// <summary>
    /// Generates a nonce (number used once) as a unique random string. This is required for client signatures.
    /// Note: This method is not guaranteed to be unique, but it is sufficient for this example.
    /// </summary>
    /// <returns>A Base64 encoded nonce string.</returns>
    private static string GenerateNonce()
    {
        byte[] data = new byte[32];

        using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
        {
            rng.GetBytes(data);
        }

        // Convert the byte array to a Base64 string
        return Convert.ToBase64String(data);
    }

    /// <summary>
    /// Creates a new account using the provided API key, secret, username, password, and email.
    /// </summary>
    /// <param name="accountApi">The AccountApi instance to make the request.</param>
    /// <param name="apiKey">API key for authentication.</param>
    /// <param name="apiSecret">API secret for generating the signature.</param>
    /// <param name="username">Username for the new account.</param>
    /// <param name="password">Password for the new account.</param>
    /// <param name="mail">Email address for the new account.</param>
    public static async Task<CreateAccountResponse> CreateAccount(AccountApi accountApi, string apiKey, string apiSecret, string username, string password, string mail)
    {
        //Generate a nonce
        string nonce = GenerateNonce();

        //Generate client signature for the request
        string host = accountApi.Configuration.BasePath.Replace("https://", "").Replace("http://", "");
        string s = $"{username}:{host}:{mail}:{password}:{apiKey}:{nonce}";

        // UTF-8 encode the api secret and the concatenated string
        byte[] key = Encoding.UTF8.GetBytes(apiSecret);
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

        CreateAccountBody body = new CreateAccountBody(username, mail, password, apiKey, nonce, signature, 360);
        CreateAccountResponse response = await accountApi.CreateAccountAsync(body);

        return response;
    }


    /// <summary>
    /// Logs in a user using their username and password.
    /// </summary>
    /// <param name="accountApi">The AccountApi instance to make the login request.</param>
    /// <param name="username">Username for the account.</param>
    /// <param name="password">Password for the account.</param>
    /// <returns>The response from the login API call.</returns>
    public static async Task<LoginResponse> Login(AccountApi accountApi, string username, string password)
    {
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




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
    //For client signatures a nonce is required
    //From the neuron documentatin: "A unique random string, at least 32 characters long, with sufficient entropy to not be reused again. If reused, an error will be returned."
    //this function is not garantueed to be unique, but is sufficient for the example
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

    private static async Task VerifyEMail(AccountApi accountApi, string mail)
    {
        Console.WriteLine("Enter code sent to " + mail + ":");
        string code = Console.ReadLine();
        await accountApi.VerifyEMailAsync(new VerifyEMailBody(mail, code));
    }

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




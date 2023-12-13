using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TAG.Networking.Agent.Api;
using TAG.Networking.Agent.Model;

namespace WalletExample
{
    public static class AccountActions
    {
        public static async Task<CreateAccountResponse> CreateAccount(string apiKey, string apiSecret, string username, string password, string eMail)
        {
            AccountApi api = new AccountApi(GlobalConfig.instance);

            //Generate a nonce
            string nonce = Utils.GenerateNonce();

            //Generate client signature for the request
            string host = api.Configuration.BasePath.Replace("https://", "").Replace("http://", "");
            string s = $"{username}:{host}:{eMail}:{password}:{apiKey}:{nonce}";

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

            //Create the request
            CreateAccountBody request = new CreateAccountBody(username, eMail, password, apiKey, nonce, signature, 3600);
            return await api.CreateAccountAsync(request);
        }

        public static async Task<LoginResponse> Login(string username, string password)
        {
            AccountApi api = new AccountApi(GlobalConfig.instance);

            //Generate a nonce
            string nonce = Utils.GenerateNonce();

            //Generate client signature for the request
            string host = api.Configuration.BasePath.Replace("https://", "").Replace("http://", "");
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

            LoginBody body = new LoginBody(username, nonce, signature, 3600); 
            return await api.LoginAsync(body);
        }

        public static async Task<VerifyEMailResponse> VerifyEMail(string eMail, string code)
        {
            AccountApi api = new AccountApi(GlobalConfig.instance);
            return await api.VerifyEMailAsync(new VerifyEMailBody(eMail, code));
        }
    }
}

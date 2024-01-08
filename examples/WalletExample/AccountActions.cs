using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Neuron.Agent.Api;
using Neuron.Agent.Model;

namespace WalletExample
{

    /// <summary>
    /// Contains methods for account actions.
    /// </summary>
    public static class AccountActions
    {
        /// <summary>
        /// Asynchronously creates a new account.
        /// </summary>
        /// <param name="apiKey">The API key for account creation.</param>
        /// <param name="apiSecret">The API secret for account creation.</param>
        /// <param name="username">The desired username for the new account.</param>
        /// <param name="password">The password for the new account.</param>
        /// <param name="eMail">The email address associated with the new account.</param>
        /// <returns>The task containing the <see cref="CreateAccountResponse"/> object.</returns>
        public static async Task<CreateAccountResponse> CreateAccount(string apiKey, string apiSecret, string username, string password, string eMail)
        {
            AccountApi api = new AccountApi(GlobalConfig.instance);

            //Generate a nonce
            string nonce = Utils.GenerateNonce();

            //Generate client signature for the request
            string host = api.Configuration.BasePath.Replace("https://", "").Replace("http://", "");
            string s = $"{username}:{host}:{eMail}:{password}:{apiKey}:{nonce}";
            string signature = Utils.Sign(s, apiSecret);

            //Create the request
            CreateAccountBody request = new CreateAccountBody(username, eMail, password, apiKey, nonce, signature, 3600);
            return await api.CreateAccountAsync(request);
        }

        /// <summary>
        /// Asynchronously logs in to an account.
        /// </summary>
        /// <param name="username">The username of the account.</param>
        /// <param name="password">The password of the account.</param>
        /// <returns>The task containing the <see cref="LoginResponse"/> object.</returns>
        public static async Task<LoginResponse> Login(string username, string password)
        {
            AccountApi api = new AccountApi(GlobalConfig.instance);

            //Generate a nonce
            string nonce = Utils.GenerateNonce();

            //Generate client signature for the request
            string host = api.Configuration.BasePath.Replace("https://", "").Replace("http://", "");
            string s = $"{username}:{host}:{nonce}";

            string signature = Utils.Sign(s, password);

            LoginBody body = new LoginBody(username, nonce, signature, 3600);
            return await api.LoginAsync(body);
        }

        /// <summary>
        /// Asynchronously verifies an email address.
        /// </summary>
        /// <param name="eMail">The email associated with a newly created account</param>
        /// <param name="code">The code sent to the associated email</param>
        /// <returns>The task containing the <see cref="VerifyEMailResponse"/> object.</returns>
        public static async Task<VerifyEMailResponse> VerifyEMail(string eMail, string code)
        {
            AccountApi api = new AccountApi(GlobalConfig.instance);
            return await api.VerifyEMailAsync(new VerifyEMailBody(eMail, code));
        }


    }
}

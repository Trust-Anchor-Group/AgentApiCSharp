using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalletExample
{

    /// <summary>
    /// Utility class containing helper functions
    /// </summary>
    static class Utils
    {
        /// <summary>
        /// Generates a random 32 character string
        /// </summary>
        /// <returns>A 32 char string</returns>
        public static string GenerateNonce()
        {
            return Guid.NewGuid().ToString("n");

        }

        /// <summary>
        /// Calculated the HMAC-SHA256 signature using data and a key
        /// </summary>
        /// <param name="data">The data to be encrypted seperated by colon, eg "bar:foo"</param>
        /// <param name="key">The key used for encryption</param>
        /// <returns>The HMAC generated from data and key</returns>
        public static string Sign(string data, string key)
        {
            byte[] keyBytes = Encoding.UTF8.GetBytes(key);
            byte[] dataBytes = Encoding.UTF8.GetBytes(data);

            using (System.Security.Cryptography.HMACSHA256 hmac = new System.Security.Cryptography.HMACSHA256(keyBytes))
            {
                byte[] signatureBytes = hmac.ComputeHash(dataBytes);
                return Convert.ToBase64String(signatureBytes);
            }
        }
    }
}

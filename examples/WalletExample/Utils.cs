using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalletExample
{

    /// <summary>
    /// Utility class containting helper functions
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
    }
}

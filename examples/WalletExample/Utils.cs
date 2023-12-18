
using System.Security.Cryptography;


namespace WalletExample
{
    public static class Utils
    {
        public static string GenerateNonce()
        {
            byte[] data = new byte[32];

            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(data);
            }

            // Convert the byte array to a Base64 string
            return Convert.ToBase64String(data);
        }
    }
}

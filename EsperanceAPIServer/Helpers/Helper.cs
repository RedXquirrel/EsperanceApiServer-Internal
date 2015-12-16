using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EsperanceAPIServer.Helpers
{
    public class Helper
    {
        public static string GetHash(string input)
        {
            // input = "The quick brown fox.";
            HashAlgorithm hashAlgorithm = new SHA256CryptoServiceProvider();

            byte[] byteValue = System.Text.Encoding.UTF8.GetBytes(input);

            byte[] byteHash = hashAlgorithm.ComputeHash(byteValue);

            var base64 = Convert.ToBase64String(byteHash);

            return base64;
        }
    }
}

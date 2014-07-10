using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3._2_004
{
    class Program
    {
        static void Main(string[] args)
        {

            UnicodeEncoding ByteConverter = new UnicodeEncoding();

            byte[] dataToEncrypt = ByteConverter.GetBytes("Willamar");

            string containerName = "SecretContainer";

            CspParameters csp = new CspParameters() { KeyContainerName = containerName };

            byte[] encryptedData;

            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(csp))
            {
                encryptedData = RSA.Encrypt(dataToEncrypt, false);
            }

            foreach (var item in encryptedData)
            {
                Console.Write(item);
            }

            Console.WriteLine();

            byte[] decryptedData;

            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(csp))
            {
                decryptedData = RSA.Decrypt(encryptedData, false);
            }

            Console.WriteLine(ByteConverter.GetString(decryptedData));

            Console.Read();


        }

    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3._2_001
{
    class Program
    {
        static void Main(string[] args)
        {
            EncrypSomeText();
        }

        public static void EncrypSomeText()
        {
            string original = "My secret data!";

            using (SymmetricAlgorithm symmetricAlgorithm = new AesManaged())
            {
                byte[] encrypted = Encrypted(symmetricAlgorithm, original);
                string roundtrip = Decrypt(symmetricAlgorithm, encrypted);

               

                Console.WriteLine("original:    {0}", original);
                Console.Write("Encrypted:   ");
                foreach (var item in encrypted)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
                Console.WriteLine("Round Trip   {0}", roundtrip);

                Console.Read();
            }
        }

       

        private static byte[] Encrypted(SymmetricAlgorithm aesAlg, string plainText)
        {
            ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

            using (MemoryStream msEncrypt = new MemoryStream())
            {
                using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                {

                    using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(plainText);
                    }
                    return msEncrypt.ToArray();

                }
            }
        }

         private static string Decrypt(SymmetricAlgorithm aesAlg, byte[] cipherText)
        {
            ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

            using (MemoryStream msDecrypt = new MemoryStream(cipherText))
            {
                using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                {
                    using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                    {
                        return srDecrypt.ReadToEnd();
                    }
                }
            }
        }
    }
}

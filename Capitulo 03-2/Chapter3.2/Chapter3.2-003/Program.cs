using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Chapter3._2_003
{
    class Program
    {
        static void Main(string[] args)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();

            string publicKeyXML = rsa.ToXmlString(false);

            string privateKeyXML = rsa.ToXmlString(true);
            
            
            UnicodeEncoding ByteConverter = new UnicodeEncoding();



            byte[] dataToEncrypt = ByteConverter.GetBytes("My Secret Data!");

            byte[] encryptedData;

            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {
                RSA.FromXmlString(publicKeyXML);

                encryptedData = RSA.Encrypt(dataToEncrypt, false);
            }

            byte[] decryptedData;

            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {
                RSA.FromXmlString(privateKeyXML);

                decryptedData = RSA.Decrypt(encryptedData, false);
            }

            string decryptedString = ByteConverter.GetString(decryptedData);

            Console.WriteLine(decryptedString);

            Console.Read();
        }
    }
}

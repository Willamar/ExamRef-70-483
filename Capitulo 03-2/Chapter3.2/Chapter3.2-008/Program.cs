using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3._2_008
{
    class Program
    {

        //Antes de roda esse exemplo executar os comandos no prompt de comando 
        //makecert testCert.cer
        //makecert -n “CN=WouterDeKort” -sr currentuser -ss testCertStore

        static void Main(string[] args)
        {
            SingAndVerify();

            Console.Read();
        }

        public static void SingAndVerify()
        {
            string textToSign = "Test paragraph";
            byte[] signature = Sing(textToSign, "cn=WouteDeKort");
            //Uncoment this line to make the verification step fail
            //signature[0] = 0;

            Console.WriteLine(Verify(textToSign, signature));
        }

        private static byte[] Sing(string text, string certSubject)
        {
            X509Certificate2 cert = GetCertificate();
            var csp = (RSACryptoServiceProvider)cert.PrivateKey;
            byte[] hash = HashData(text);

            return csp.SignHash(hash, CryptoConfig.MapNameToOID("SHA1"));
        }

        private static bool Verify(string text, byte[] signature)
        {
            X509Certificate2 cert = GetCertificate();
            var csp = (RSACryptoServiceProvider)cert.PublicKey.Key;
            byte[] hash = HashData(text);
            return csp.VerifyHash(hash, CryptoConfig.MapNameToOID("SHA1"), signature);
        }

        private static X509Certificate2 GetCertificate()
        {
            X509Store my = new X509Store("testCertStore", StoreLocation.CurrentUser);
            my.Open(OpenFlags.ReadOnly);

            var certificate = my.Certificates[0];
            return certificate;
        }

       

        private static byte[] HashData(string text)
        {
            HashAlgorithm hashAlgorithm = new SHA1Managed();
            UnicodeEncoding enconding = new UnicodeEncoding();
            byte[] data = enconding.GetBytes(text);

            byte[] hash = hashAlgorithm.ComputeHash(data);
            return hash;
        }

    }
}

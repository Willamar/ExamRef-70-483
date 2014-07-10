using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3._2_002
{
    class Program
    {
        static void Main(string[] args)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();

            string publicKeyXML = rsa.ToXmlString(false);

            string privateKeyXML = rsa.ToXmlString(true);

            Console.WriteLine(publicKeyXML);
            Console.WriteLine(privateKeyXML);

            Console.Read();
        }
    }
}

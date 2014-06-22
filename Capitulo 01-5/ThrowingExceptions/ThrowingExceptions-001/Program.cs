using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThrowingExceptions_001
{
    class Program
    {

        static void Main(string[] args)
        {
            
        }

        public static string OpenAndParse(string filneName)
        {
            if (String.IsNullOrWhiteSpace(filneName))
                throw new ArgumentNullException("fileName", "Filename is required");

            return "Sucess!!";
        }
    }
}

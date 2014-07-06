using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulateString_010
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "My Custom Value";
            foreach (char c in value)
            {
                Console.WriteLine(c);
            }

            Console.Read();
        }
    }
}

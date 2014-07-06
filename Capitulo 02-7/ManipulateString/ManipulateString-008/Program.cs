using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulateString_008
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "My Sample value";
            string substring = value.Substring(3, 6);

            Console.WriteLine(substring);


            Console.Read();
        }
    }
}

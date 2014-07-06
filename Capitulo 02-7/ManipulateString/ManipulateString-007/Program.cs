using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulateString_007
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "<mycustominput>";
            if (value.StartsWith("<")) { Console.WriteLine(true); }
            if (value.EndsWith(">")) { Console.WriteLine(false); }

            Console.Read();
        }
    }
}

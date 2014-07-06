using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulateString_002
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("A initial value");

            sb[0] = 'B';


            Console.Write(sb.ToString());

            Console.Read();
        }
    }
}

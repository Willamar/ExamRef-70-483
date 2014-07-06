using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulateString_012
{
    class Program
    {
        static void Main(string[] args)
        {
            double cost = 1234.56;

            Console.WriteLine(cost.ToString("C", new System.Globalization.CultureInfo("pt-br")));

            Console.Read();
        }
    }
}

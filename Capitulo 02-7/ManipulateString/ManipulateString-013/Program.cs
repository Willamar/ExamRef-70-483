using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulateString_013
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2014, 7, 5);
            CultureInfo provider = new CultureInfo("pt-br");

            Console.WriteLine(d.ToString("d", provider));
            Console.WriteLine(d.ToString("D", provider));
            Console.WriteLine(d.ToString("M", provider));

            Console.Read();
        }
    }
}

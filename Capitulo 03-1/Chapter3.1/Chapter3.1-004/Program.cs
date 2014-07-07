using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3._1_004
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo english = new CultureInfo("En");

            CultureInfo dutch = new CultureInfo("Nl");

            string value = "€19,95";

            decimal d = decimal.Parse(value, NumberStyles.Currency, dutch);

            Console.WriteLine(d);

            Console.WriteLine(d.ToString(english));

            Console.Read();

        }
        
    }
}

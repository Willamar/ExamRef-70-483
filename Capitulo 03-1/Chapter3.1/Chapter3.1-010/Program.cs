using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3._1_010
{
    class Program
    {
        static void Main(string[] args)
        {
            // json começa com { e terminar com }
            // ou começa com [ e termina com ]
            Console.WriteLine("{json:}");

            Console.Read();
        }

        public static bool IsJson(string input)
        {
            input = input.Trim();

            return input.StartsWith("{") && input.EndsWith("}")
                || input.StartsWith("[") && input.EndsWith("]");
        }
    }
}

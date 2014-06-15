using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booleans_005
{
    class Program
    {
        static void Main(string[] args)
        {
            Process(Console.ReadLine());
            Console.Read();
        }

        private static void Process(string input)
        {
            bool result = (input != null) && (input.StartsWith("v"));
            Console.WriteLine(result);
        }
    }
}

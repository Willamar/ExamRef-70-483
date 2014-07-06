using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulateString_015
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;

            string result = string.Format("a: {0}, b: {1}", a, b);

            Console.WriteLine(result);

            Console.Read();
        }
    }
}

#define MySymbol

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3._4_003
{
    class Program
    {
        static void Main(string[] args)
        {
#if MySymbol
            Console.WriteLine("Custom symbol is defined");
#endif

            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3._4_002
{
    class Program
    {
        static void Main(string[] args)
        {
            DebugDirective();
            Console.Read();
        }

        public static void DebugDirective()
        {
#if DEBUG
            Console.WriteLine("Debug mode");
#else
            Console.WriteLine("NOt debug");
#endif
        }
    }
}

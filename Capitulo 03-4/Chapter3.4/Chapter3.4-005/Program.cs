using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3._4_005
{
    class Program
    {
        static void Main(string[] args)
        {
            Log("log");

            Console.Read();
        }

        [Conditional("DEBUG")]
        private static void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}

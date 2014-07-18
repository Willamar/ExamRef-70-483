using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3._5_007
{
    class Program
    {
        const int numberOfIteration = 1000000;
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Algorithm1();
            sw.Stop();

            Console.WriteLine(sw.Elapsed);

            sw.Reset();
            sw.Start();
            Algorithm2();
            sw.Stop();
            Console.WriteLine(sw.Elapsed);

            Console.WriteLine("Ready_");
            Console.ReadLine();

        }

        private static void Algorithm2()
        {
            string result = "";
            for (int i = 0; i < numberOfIteration; i++)
            {
                result += 'a';
            }
        }

        private static void Algorithm1()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < numberOfIteration; i++)
            {
                sb.Append('a');
            }

            string result = sb.ToString();
        }
    }
}

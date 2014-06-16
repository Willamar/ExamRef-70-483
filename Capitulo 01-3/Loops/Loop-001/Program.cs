using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_001
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = { 1, 2, 3, 4, 5, 6 };
            //for (initial; condition; loop)
            for (int i = 0; i < values.Length; i++)
            {
                Console.WriteLine(values[i]);
            }

            Console.Read();
        }
    }
}

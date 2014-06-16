using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_002
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = { 1, 2, 3, 4, 5, 6 };
            for (int x = 0, y = values.Length -1; ((x < values.Length) && (y >= 0)); x++, y--)
            {
                Console.Write(values[x]);
                Console.Write(values[y]);
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}

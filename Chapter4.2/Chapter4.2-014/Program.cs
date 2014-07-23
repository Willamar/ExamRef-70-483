using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4._2_014
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data1 = { 1, 2, 5 };
            int[] data2 = { 2, 4, 6 };

            var result = from d1 in data1
                         from d2 in data2
                         select d1 * d2;

            Console.WriteLine(string.Join(", ", result));

        }
    }
}

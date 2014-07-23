using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4._2_013
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 1, 2, 5, 8, 11 };

            var result = from d in data
                         where d > 5
                         orderby d descending
                         select d;

            Console.WriteLine(string.Join(", ", result));
        }
    }
}

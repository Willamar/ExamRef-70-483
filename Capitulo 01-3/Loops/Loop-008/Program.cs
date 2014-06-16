using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_008
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = { 1, 2, 3, 4, 5, 6 };
            foreach (var item in values)
            {
                Console.Write(item);
            }

            Console.Read();
        }
    }
}

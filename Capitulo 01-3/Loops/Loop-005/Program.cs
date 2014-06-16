using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_005
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = { 1, 2, 3, 4, 5, 6 };
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == 4)
                {
                    continue;
                }
                Console.WriteLine(values[i]);
            }

            Console.Read();
        }
    }
}

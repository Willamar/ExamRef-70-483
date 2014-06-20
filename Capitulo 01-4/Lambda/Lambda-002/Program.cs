using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_002
{
    class Program
    {
        public delegate int Calculate(int x, int y);
        static void Main(string[] args)
        {
            Calculate calc =
                (x, y) =>
                {
                    Console.WriteLine("Adding numbers");
                    return x + y;
                };

            int result = calc(3, 4);



        }
    }
}

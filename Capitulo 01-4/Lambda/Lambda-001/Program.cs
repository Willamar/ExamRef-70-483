using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_001
{
    class Program
    {
        public delegate int Calculate(int x, int y);
        static void Main(string[] args)
        {

            Calculate calc = (x, y) => x + y;
            Console.WriteLine(calc(3, 4));
            calc = (x, y) => x * y;
            Console.WriteLine(calc(3, 4));

            Console.Read();
        }
    }
}

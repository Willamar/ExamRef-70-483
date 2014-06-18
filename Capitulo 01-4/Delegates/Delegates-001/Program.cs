using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_001
{
    class Program
    {

        public delegate int Caculate(int x, int y);

        public static int Add(int x, int y) { return x + y; }

        public static int Multiply(int x, int y) { return x * y; }

        static void Main(string[] args)
        {
            Caculate calc = Add;
            Console.WriteLine(calc(3, 4));

            calc = Multiply;
            Console.WriteLine(calc(3, 4));

            Console.Read();
        }
    }
}

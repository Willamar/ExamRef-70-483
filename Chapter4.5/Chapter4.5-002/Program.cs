using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter4._5_002
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] array2d = new string[3, 2] {
                {"one", "two"},
                {"three", "four"},
                {"five", "six"}
            };

            Console.WriteLine(array2d[0, 0]);
            Console.WriteLine(array2d[0, 1]);
            Console.WriteLine(array2d[1, 0]);
            Console.WriteLine(array2d[1, 1]);
            Console.WriteLine(array2d[2, 0]);
            Console.WriteLine(array2d[2, 1]);

            Console.Read();
        }
    }
}

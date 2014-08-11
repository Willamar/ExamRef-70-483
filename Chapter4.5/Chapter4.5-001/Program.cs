using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter4._5_001
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfInt = new int[10];

            for (int x = 0; x < arrayOfInt.Length; x++)
            {
                arrayOfInt[x] = x;
            }

            foreach (var i in arrayOfInt)
            {
                Console.Write(i);
            }

            Console.Read();
        }
    }
}

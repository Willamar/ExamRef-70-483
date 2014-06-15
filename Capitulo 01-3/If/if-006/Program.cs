using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_006
{
    class Program
    {
        static void Main(string[] args)
        {
            bool x = true;
            bool y = true;



            if (x)
            {
                if (y)
                {
                    Console.WriteLine("x and y are true");
                }
                else
                {
                    Console.WriteLine("x is true and y is false");
                }
            }

            Console.Read();
        }
    }
}

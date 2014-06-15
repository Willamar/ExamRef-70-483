using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_002
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b = true;
            if (b)
                Console.WriteLine("Sem chaves");

            if (b)
            {
                Console.WriteLine("Both these lines");
                Console.WriteLine("will be executed");
            }

            Console.Read();
        }
    }
}

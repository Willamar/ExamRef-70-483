using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booleans_006
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            bool b = false;
            //Operador ^(XOR), somente retorna true se somente um deles for verdadeiro

            Console.WriteLine(a ^ a);
            Console.WriteLine(a ^ b);
            Console.WriteLine(b ^ b);

            /*
             * Tabela XOR 
             * 
             *  true com false = true;
             *  false com true = true;
             *  true  com true =  false;
             *  false com false = true; 
             */

            Console.Read();
        }
    }
}

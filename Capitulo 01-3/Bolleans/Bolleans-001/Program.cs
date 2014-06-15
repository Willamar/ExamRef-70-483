using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolleans_001
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 42;
            int y = 1;
            int z = 42;

            Console.WriteLine(x == y); //false

            Console.WriteLine(x == z); //true

            Console.Read();

            /* 
             * Operadores relacionais
             * Operador     Descrição               Exemplo
             *  <           Menor que               x < 42;
             *  >           Maior que               x > 42;
             *  <=          Menor ou igual          x <= 42;
             *  >=          Maior ou igual          x >=42
             *  ==          Igual a                 x == 42;
             *  !=          Diferente               x != 42;
             */
        }
    }
}

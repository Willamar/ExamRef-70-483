using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalOperator_001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetValue(true));

            Console.Read();
        }

        private static int GetValue(bool p)
        {
            //if (p)
            //{
            //    return 1;
            //}
            //else
            //{
            //    return 0;
            //}

            //exemplo de como utilizar o conditional operator(operador ternario)
            // é uma forma simplificada de escrever if e else para poder atribuir valores
            //exemplo a abaixo é como seria escrever de forma simples o if logo acima
            return p ? 1 : 0;
        }
    }
}

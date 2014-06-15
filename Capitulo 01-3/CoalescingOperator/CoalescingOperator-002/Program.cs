using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoalescingOperator_002
{
    class Program
    {
        static void Main(string[] args)
        {
            int? x = null;
            int? z = null;

            //se x e z for nulo sera atribuido o valor de -1 
            // se x não for nulo será atribuido o valor de x ao y
            // se x for nulo e z não, será atribuido o valor de z em y
            int y = x ?? z ?? -1;

            Console.WriteLine(y);

            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoalescingOperator_001
{
    class Program
    {
        static void Main(string[] args)
        {
            int? x = null;
         
            //se x for nulo então será atribuido o valor de -1
            // se x não for nulo sera atribuido o valor de x em y
            int y = x ?? -1;

            Console.WriteLine(y);

            Console.Read();
        }
    }
}

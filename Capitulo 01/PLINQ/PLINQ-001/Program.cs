using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLINQ_001
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0, 100); 
            //O compilador verifica se faz sentido transforma a query em paralelo
            // Caso seja sentido ele vai gera objetos task e logo em seguida executas elas
            var parallelResult = numbers.AsParallel().Where(i => i % 2 == 0).ToArray();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLINQ_004
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0, 20);

            var parallelResult = numbers.AsParallel().AsOrdered()
                .Where(i => i % 2 == 0).AsSequential();
            /*
             * Se você tiver uma consulta complexa que pode se beneficiar de 
             * processamento paralelo, mas também tem algumas partes que devem 
             * ser feitas em seqüência, você pode usar o AsSequential para parar a 
             * sua consulta a partir do que está sendo processado em paralelo. 
             * Tradução do google translate do livro sobre a definição do AsSequential
             */

            foreach (var item in parallelResult.Take(5))
            {
                Console.Write(item);
            }

            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLINQ_002
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0, 10);
            var parallelResult = numbers.AsParallel().Where(i => i % 2 == 0)
                .ToArray();
            foreach (int item in parallelResult)
            {
                Console.WriteLine(item);
            }
            //Podemos reparar que o resulta pode ou não está em ordem, porque isso depende da quantidade de CPU
            //Disponivel para execução do metodo, como ele vai executa em paralelo, ou seja ele vai jogando no array o que ele terminar primeiro
            //No proximo exemplo mostra como que faz pra ordernar
            Console.Read();
        }
    }
}

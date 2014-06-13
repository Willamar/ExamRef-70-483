using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLINQ_006
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(1, 20);

            try
            {
                var parallelResult = numbers.AsParallel().Where(i => IsEvent(i));

                parallelResult.ForAll(x => Console.WriteLine(x));
            }
            catch (AggregateException ex)
            {
                Console.WriteLine("There where {0} exceptions", ex.InnerExceptions.Count);
            }
            finally
            {
                Console.Read();
            }
        }

        private static bool IsEvent(int i)
        {
            if (i % 10 == 0)
            {
                throw new ArgumentException(i.ToString());
            }
            //Quando i % 10 for igual a 0 ele irá retorna uma excption, se estiver debugando
            //essa linha irá dar um erro porque você já declarou uma excption
            return i % 2 == 0;

        }
    }
}

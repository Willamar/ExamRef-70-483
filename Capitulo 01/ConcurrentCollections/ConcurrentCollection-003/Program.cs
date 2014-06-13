using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrentCollection_003
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcurrentBag<int> bag = new ConcurrentBag<int>();

            bag.Add(123);
            bag.Add(321);
            bag.Add(123123);

            int result;

            if (bag.TryTake(out result))
            {
                Console.WriteLine(result);
            }

            if (bag.TryTake(out result))
            {
                Console.WriteLine(result);
            }

            if (bag.TryPeek(out result))
            {
                Console.WriteLine("There is a next itam: {0}", result);
            }

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrentCollections_006
{
    class Program
    {
        static void Main(string[] args)
        {
            //QUEUE - Fila (FIFO) 
            ConcurrentQueue<int> queue = new ConcurrentQueue<int>();

            //metodo ENQUEUE coloca um item na coleção
            queue.Enqueue(42);

            int result;
            //metodo TryDequeue Retira um item da coleção
            if (queue.TryDequeue(out result))
            {
                Console.WriteLine("Dequeued: {0}", result);
            }

            Console.ReadLine();
        }
    }
}

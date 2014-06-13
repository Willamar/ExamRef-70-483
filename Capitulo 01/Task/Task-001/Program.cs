using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_001
{
    class Program
    {
        static void Main(string[] args)
        {
            Task t = Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.Write("*");
                    Thread.Sleep(10);
                }
            });
            /*
             O metodo Wait é o equivalente ao metodo Thread.Join() 
             * ele espera terminar a Task para poder encerrar 
             * para entender melhor execute o programa com a linha abaixo comenteado, 
             * e depois execute com ele descomentada, para poder ver a diferença.
             */
            t.Wait();
        }
    }
}

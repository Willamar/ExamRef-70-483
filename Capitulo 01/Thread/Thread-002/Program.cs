using System;
using System.Threading;

namespace Thread_002
{
    class Program
    {
        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(1000);
            }
        }

        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod));

            /* 
             * Quando a propriedade IsBackGroud é setado como true
             * o programa é encerrado, não espera o metodoThreadMethod termina para
             * poder encerrar o programa
             * Quando é setada como false, ele faz o contratio, ele espera o método 
             * encerrar
             */

            t.IsBackground = true;
            //t.IsBackground = false;

            t.Start();

        }
    }
}

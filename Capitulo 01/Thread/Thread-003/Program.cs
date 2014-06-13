using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread_003
{
    class Program
    {
        public static void ThreadMethod(object o)
        {
            for (int i = 0; i < (int)o; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(0);
            }
        }

        static void Main(string[] args)
        {
            Thread t = new Thread(new ParameterizedThreadStart(ThreadMethod));

            //o parametro cinco é passado para o metodo ThreadMethod
            t.Start(5);
            
            //Metodo pode ser usado para para a thread
            //t.Abort();
            
            t.Join();

            Console.Read();
        }
    }
}

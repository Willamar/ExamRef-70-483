using System;
using System.Threading;

namespace Thread_001
{
    class Program
    {
        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(10);
            }
        }

        static void Main(string[] args)
        {
            //Thread é uma classe da System.Threading(Não esquece de dar um using);
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            t.Start();

            for (int i = 0; i < 4; i++)
			{
                Console.WriteLine("Main thread: Do some work.");
                Thread.Sleep(10);
			}

            t.Join();

            Console.ReadLine();
        }
    }
}

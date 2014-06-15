using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InterlockedClass_002
{
    public static class Program
    {
        static int value = 1;


        static void Main(string[] args)
        {
            Task t1 = Task.Run(() =>
            {
                //if (value == 1)
                //{
                //    Thread.Sleep(1000);
                //    value = 2;
                //}

                Interlocked.CompareExchange(ref value, 2, 1);
            });

            Task t2 = Task.Run(() =>
            {
                //value = 3;
                Interlocked.CompareExchange(ref value, 3, 2);
            });


            Task.WaitAll(t1, t2);
            Console.WriteLine(value);

            Console.Read();
        }
    }
}

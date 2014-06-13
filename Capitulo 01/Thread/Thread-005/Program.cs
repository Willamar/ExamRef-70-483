using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread_005
{
    class Program
    {
        //Com o atributo abaixo o valor maximo que a variavel vai chegar é 10
        //se tirarmos o valor maximo da variavel vai ser 20
        [ThreadStatic]
        public static int _field;

        public static void Main()
        {
            new Thread(() =>
                {
                    for (int i = 0; i < 10; i++)
                    {
                        _field++;
                        Console.WriteLine("Thread A: {0}", _field);
                        Thread.Sleep(1);
                    }
                }).Start();

            new Thread(() =>
                {
                    for (int i = 0; i < 10; i++)
                    {
                        _field++;
                        Console.WriteLine("ThreadB: {0}", _field);
                        Thread.Sleep(1);
                    }
                }).Start();

            Console.ReadLine();
        }

        
    }
}

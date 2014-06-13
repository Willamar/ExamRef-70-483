using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_002
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task com retorno
            Task<int> t = Task.Run(() =>
            {
                int result = 0;
                for (int i = 0; i < 10; i++)
                {
                    result += i;
                    Thread.Sleep(1000);
                }
                return result;
                //return 42;
            });

            //para poder ler a propriedade Result tem que esperar a Task seja termina
            //enquanto a taks não é terminado o programa não continua
            Console.WriteLine(t.Result);

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Parallel_001
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            Parallel.For(0, 10, i =>
            {
                //ele executa os comandos em paralelo, reparem que a variavel a não está seguindo uma ordem, as vezes ele pode pega o mesmo valor
                Thread.Sleep(1000);
                Console.Write(a);
                a++;
            });
            Console.WriteLine();
            var numbers = Enumerable.Range(0, 10);
            Parallel.ForEach(numbers, x =>
            {               
                Thread.Sleep(1000);
                Console.Write("*");
            });

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taks_003
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<int> t = Task.Run(() =>
            {
                return 42;
            }).ContinueWith((i) =>
            {
                // metodo pega o resultado da task acima e continua com o metodo ContinueWith
                return i.Result * 2;
            });

            Console.WriteLine(t.Result);

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_004
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Task<int> t = Task.Run(() =>
            {                
                return 42;
            });


            t.ContinueWith((i) =>
            {
                //Chamado somente se a task for cancelada
                Console.WriteLine("Canceled");

            }, TaskContinuationOptions.OnlyOnCanceled);

            t.ContinueWith((i) =>
            {
                //Chamado somente se houver falha
                Console.WriteLine("Faulted");

            }, TaskContinuationOptions.OnlyOnFaulted);

            var conpletedTask = t.ContinueWith((i) =>
            {
                //Chamado quando completada
                Console.WriteLine("Completed");

            }, TaskContinuationOptions.OnlyOnRanToCompletion);

            Console.WriteLine(t.Result);            

            //conpletedTask.Wait();

            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_006
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<int[]> parent = Task.Run(() =>
            {
                var results = new int[3];

                TaskFactory tf = new TaskFactory(TaskCreationOptions.AttachedToParent, TaskContinuationOptions.ExecuteSynchronously);

                // todas as task criadas com o TaskFactory terão a mesma configuração, que foi definida na sua instância
                // Para maiores informações sobre TaskFactory acesse: http://msdn.microsoft.com/pt-br/library/system.threading.tasks.taskfactory(v=vs.110).aspx
                tf.StartNew(() => results[0] = 0);
                tf.StartNew(() => results[1] = 1);
                tf.StartNew(() => results[2] = 2);
                // Metodo StarNew é o equivalente ao metodo Task.Start()
                 
                return results;
            });

            var finalTask = parent.ContinueWith(x =>
            {
                foreach (int item in x.Result)
                {
                    Console.WriteLine(item);
                }
            });
            
            finalTask.Wait();

            Console.ReadLine();
        }
    }
}

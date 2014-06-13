using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_005
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<int[]> parent = Task.Run(() =>
            {
                var results = new int[3];

                /*
                 * para maiores informações sobre TaskCreationOptions consulte 
                 * http://msdn.microsoft.com/en-us/library/system.threading.tasks.taskcreationoptions.aspx
                 */

                new Task(() => results[0] = 0, TaskCreationOptions.AttachedToParent).Start();
                new Task(() => results[1] = 1, TaskCreationOptions.AttachedToParent).Start();
                new Task(() => results[2] = 2, TaskCreationOptions.AttachedToParent).Start();

                return results;
            });
            //finalTask só vai ser executado quando a task parent for terminada
            var finalTask = parent.ContinueWith(x =>
            {
                // percorre todos os itens que foram adicionadados na task parent
                foreach (int i in x.Result)
                {
                    Console.WriteLine(i);
                }

            });

            finalTask.Wait();

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Threading;
//Teve que adicionar a referencia a namespace System.Net.Http

namespace AsyncAWait_001
{
    class Program
    {
        static void Main(string[] args)
        {

            string result = DownloadContent().Result;
            Console.WriteLine(result);

            Console.Read();
        }
        /*
         * Quando se usar o modicador async por padrão você tem que implementar um modificador await 
         * Um metodo async pode retorna Task, Task<T> ou void
         * 
         */
        private static async Task<string> DownloadContent()
        {
            using (HttpClient client = new HttpClient())
            {

                Task<string> t = client.GetStringAsync("http://msdn.microsoft.com");
                
                // O metodo DownloadContent só vai ser continuado quando a taks t esteja terminada
                string result = await t; 
                return result;
            }
        }
    }
}

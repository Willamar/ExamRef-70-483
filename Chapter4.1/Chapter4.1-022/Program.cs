using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4._1_022
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public async Task ExecuteMultipleRequests()
        {
            HttpClient client = new HttpClient();

            string microsot = await client.GetStringAsync("hhtp://www.microsoft.com");
            string msdn = await client.GetStringAsync("hhtp://msdn.microsoft.com");
            string blogs = await client.GetStringAsync("hhtp://blogs.msdn.com");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4._1_023
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public async Task ExecuteMultipleRequestInParallel()
        {
            HttpClient client = new HttpClient();

            Task microsot = client.GetStringAsync("hhtp://www.microsoft.com");
            Task msdn =  client.GetStringAsync("hhtp://msdn.microsoft.com");
            Task blogs = client.GetStringAsync("hhtp://blogs.msdn.com");

            await Task.WhenAll(microsot, msdn, blogs);
        }
    }
}

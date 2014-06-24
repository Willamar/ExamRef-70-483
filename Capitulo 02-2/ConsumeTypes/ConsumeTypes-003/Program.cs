using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace ConsumeTypes_003
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClient p = new HttpClient();
            object o = p;
            IDisposable d = p;

        }
    }
    
}

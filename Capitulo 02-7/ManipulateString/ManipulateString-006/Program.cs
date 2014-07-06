using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulateString_006
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "My Sample value";
            int indexOfp = value.IndexOf('p');
            int lastIndexOfm = value.LastIndexOf('m');

            Console.WriteLine(indexOfp);
            Console.WriteLine(lastIndexOfm);

            Console.Read();
        }
    }
}

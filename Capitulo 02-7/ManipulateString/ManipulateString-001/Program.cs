using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulateString_001
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = string.Empty;

            for (int i = 0; i < 10000; i++)
            {
                s += "x";
            }
        }
    }
}

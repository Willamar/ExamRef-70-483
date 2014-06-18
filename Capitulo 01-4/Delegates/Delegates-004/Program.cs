using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_004
{
    class Program
    {
        static void DoSomenthing(TextWriter tw) { }

        public delegate void ContravarianceDel(StreamWriter tw);

        static void Main(string[] args)
        {
            ContravarianceDel del = DoSomenthing;
        }
    }
}

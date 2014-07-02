using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollection_002
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter stream = File.CreateText("temp.dat");
            stream.Write("some data");
            GC.Collect();

            GC.WaitForPendingFinalizers();
            File.Delete("temp.dat");
        }
    }

    
}

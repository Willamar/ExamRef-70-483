using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4._1_011
{
    class Program
    {
        static void Main(string[] args)
        {
            string folder = @"C:\temp";

            string fileName = "test.dat";

           // string fullPath = folder + fileName; // Results in C:\temp\test.dat
            string fullPath = Path.Combine(folder, fileName); //Results in C:\\temp\\test.dat
        }
    }
}

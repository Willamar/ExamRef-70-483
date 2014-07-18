using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4._1_012
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp\subdir\file.txt";

            Console.WriteLine(Path.GetDirectoryName(path)); // Displays C:\temp\subdir
            Console.WriteLine(Path.GetExtension(path)); // Displays .txt
            Console.WriteLine(Path.GetFileName(path)); // Displays file.txt
            Console.WriteLine(Path.GetPathRoot(path)); // Displays c:\

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4._1_016
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp\test.dat";

            using (StreamReader sr = File.OpenText(path))
            {
                Console.WriteLine(sr.ReadLine());
            }
            Console.ReadKey();
        }
    }
}

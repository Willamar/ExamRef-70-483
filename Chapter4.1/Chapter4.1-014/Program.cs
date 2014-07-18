using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4._1_014
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp\test.dat";

            using (StreamWriter sw = File.CreateText(path))
            {
                string myValue = "MyValue";
                sw.Write(myValue);
            }
        }
    }
}

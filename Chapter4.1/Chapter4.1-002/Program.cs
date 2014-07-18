using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Chapter4._1_002
{
    class Program
    {
        static void Main(string[] args)
        {
            var directory = Directory.CreateDirectory(@"C:\Temp\ProgrammingInCSharp\Directory");

            var directoryInfo = new DirectoryInfo(@"C:\Temp\ProgrammingInCSharp\DirectoryInfo");
            directoryInfo.Create();

        }
    }
}

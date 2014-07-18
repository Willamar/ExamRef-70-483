using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4._1_006
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.Move(@"C:\source", @"C:\destination");

            DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\Source");
            directoryInfo.MoveTo(@"C:\destination");
        }
    }
}

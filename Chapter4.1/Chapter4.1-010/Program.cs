using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4._1_010
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp\test.txt";

            string destPath = @"C:\temp\destTest.txt";

            File.CreateText(path).Close();
            File.Copy(path, destPath);

            FileInfo fileInfo = new FileInfo(path);
            fileInfo.CopyTo(destPath);
        }
    }
}

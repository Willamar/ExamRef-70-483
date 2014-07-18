using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Chapter4._1_018
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp\bufferedStream.txt";

            using (FileStream fileStream = File.Create(path))
            {
                using (BufferedStream bufferedStream = new BufferedStream(fileStream))
                {
                    using (StreamWriter sw = new StreamWriter(bufferedStream))
                    {
                        sw.WriteLine("A line of text");
                    }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Chapter4._1_015
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp\test.dat";

            using (FileStream fileStream = File.OpenRead(path))
            {
                byte[] data = new byte[fileStream.Length];

                for (int i = 0; i < fileStream.Length; i++)
                {
                    data[i] = (byte)fileStream.ReadByte();
                }

                Console.WriteLine(Encoding.UTF8.GetString(data));

                Console.ReadKey();
            }
        }
    }
}

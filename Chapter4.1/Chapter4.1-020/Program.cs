﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4._1_020
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public async Task CreateAndWriteAsyncToFile()
        {
            using (FileStream stream = new FileStream("test.dat", FileMode.Create, FileAccess.Write, FileShare.None, 4096, true))
            {
                byte[] data = new byte[100000];
                new Random().NextBytes(data);

                await stream.WriteAsync(data, 0, data.Length);
            }
        }
    }
}

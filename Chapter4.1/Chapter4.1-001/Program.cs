using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4._1_001
{
    class Program
    {
        static void Main(string[] args)
        {
            DriveInfo[] drivesInfo = DriveInfo.GetDrives();

            foreach (var item in drivesInfo)
            {
                Console.WriteLine("Drive {0}", item.Name);
                Console.WriteLine("  File type: {0}", item.DriveType);

                if (item.IsReady == true)
                {
                    Console.WriteLine("   Volume label: {0}", item.VolumeLabel);
                    Console.WriteLine("   File system: {0}", item.DriveFormat);

                    Console.WriteLine(" Available space to current user:{0, 15} bytes", item.AvailableFreeSpace);

                    Console.WriteLine(" Total available space           {0, 15} bytes", item.TotalFreeSpace);

                    Console.WriteLine(" Total size of drive:            {0, 15} bytes", item.TotalSize);
                }

            }

            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types_001
{
    class Program
    {
        static void Main(string[] args)
        {
            Days readingDays = Days.Monday | Days.Saturday;

            Console.WriteLine(readingDays);
        }
    }
    //se tirar a linha abaixo será mostado na leta o valor de 66
    [Flags]
    enum Days
    {
        none = 0x0,
        Sunday = 0x1,
        Monday = 0x2,
        Tuesday = 0x4,
        Wednesday = 0x8,
        Thursday = 0x10,
        Friday = 0x20,
        Saturday = 0x40,
    }
}

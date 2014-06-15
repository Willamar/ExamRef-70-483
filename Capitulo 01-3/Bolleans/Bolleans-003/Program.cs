using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolleans_003
{
    class Program
    {
        static void Main(string[] args)
        {
            OsShortCirduit();
        }

        public static void OsShortCirduit()
        {
            bool x = true;

            bool result = x || GetY();

            Console.WriteLine(result);

            Console.Read();
        }

        private static bool GetY()
        {
            Console.WriteLine("This method doesn't get called");
            return true;
        }
    }
}

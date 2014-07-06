using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ManipulateString_009
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = "(Mr\\.? |Mrs\\.? |Ms\\.? )";
            string[] names = { "Mr. Henry Hunt", "Ms. Sara Samuels", "Abraham Adams", "Ms. Nocole Norris" };
            foreach (string name in names)
            {
                Console.WriteLine(Regex.Replace(name, pattern, String.Empty));

            }

            Console.Read();
        }
    }
}

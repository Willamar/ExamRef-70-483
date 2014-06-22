using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_003
{
    class Program
    {
        static void Main(string[] args)
        {

            string s = null;

            try
            {
                int i = int.Parse(s);

            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("You need to enter a value");
            }
            catch (FormatException)
            {
                Console.WriteLine("{0} is not a valid number. Please try again", s);
            }
            Console.Read();
        }
    }
}

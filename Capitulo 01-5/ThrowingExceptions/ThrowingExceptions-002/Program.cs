using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThrowingExceptions_002
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                RethrowingException();
            }
            catch (Exception logEx)
            {
                Console.WriteLine("Exption: {0}", logEx.Message);
            }

            Console.Read();
        }

        private static void RethrowingException()
        {

            try
            {
                SomeOperation();
            }
            catch (Exception logEx)
            {

                Log(logEx);
                throw; //relança a excption original
            }
        }
        private static void SomeOperation()
        {
            int s = int.Parse("NaN");
        }

        private static void Log(Exception logEx)
        {
            Console.WriteLine("Log Exception");
        }

    }
}

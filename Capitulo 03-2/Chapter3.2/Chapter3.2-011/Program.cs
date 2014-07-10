using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3._2_011
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SecureString ss = new SecureString())
            {
                Console.Write("please enter password: ");
                while (true)
                {
                    
                    ConsoleKeyInfo cki = Console.ReadKey(true);
                    if (cki.Key == ConsoleKey.Enter) break;

                    ss.AppendChar(cki.KeyChar);
                    Console.Write("*");
                }
                ss.MakeReadOnly();              

               // ss.AppendChar('a');
            }
        }
    }
}

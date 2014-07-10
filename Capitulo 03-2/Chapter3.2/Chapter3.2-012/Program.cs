using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3._2_012
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

                Console.WriteLine();

                ConvertToUnsecureString(ss);

                Console.Read();
            }
        }

        private static void ConvertToUnsecureString(SecureString securePassword)
        {
            IntPtr unmanagedString = IntPtr.Zero;

            try
            {
                unmanagedString = Marshal.SecureStringToGlobalAllocUnicode(securePassword);
                Console.WriteLine(Marshal.PtrToStringUni(unmanagedString));
            }
            finally
            {
                Marshal.ZeroFreeGlobalAllocUnicode(unmanagedString);
            }
        }
    }
}

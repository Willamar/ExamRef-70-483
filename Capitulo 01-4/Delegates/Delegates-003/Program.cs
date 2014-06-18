using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_003
{
    class Program
    {
        public delegate TextWriter CovarianveDel();

        public static StreamWriter MethodStream() { return null; }

        public static StringWriter MethodString() { return null; }

        static void Main(string[] args)
        {
            CovarianveDel del;
            del = MethodStream;
            del += MethodString;
            //Apesar do dois metodos não retornarem o mesmo tipo ele não vai dar erro
            //Porque os dois( StreamWriter e StringWriter) herdam de TextWriter
            //Pra ter certeza é só aperta F12 no StreamWriter que vai abrir a tela com sua implementação


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulateString_003
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder(string.Empty);

            for (int i = 0; i < 10000; i++)
            {
                sb.Append("x");
            }

            Console.WriteLine(sb.ToString());

            Console.Read();

            // no exemplo acima poderiamos usar como está abaixo que teria uma performance melhor, 
            //mas se trabalhar como dados variaveis não temos como utilizar isso, 
            //para isso usaremos o StringBuilder que armazena as informações em buffer
            //string a = new string('x', 10000);


        }
    }
}

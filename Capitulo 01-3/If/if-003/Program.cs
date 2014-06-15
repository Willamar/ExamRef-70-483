using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_003
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b = true;

            if (b)
            {
                int r = 42;
                b = false;
            }

            // r só pode ser acessada de dentro do bloco if
            // b é falso agora

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeTypes_002
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 42;
            double d = i;
            //Conversão implicita, não preciso converter um tipo int para double, mas o contratio daria erro
            //exemplo de erro logo abaixo
            //double d2 = 4;
            //int i2 = d2;
        }
    }
}

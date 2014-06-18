using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_002
{
    class Program
    {
        public static void MethodOne()
        {
            Console.WriteLine("MethodOne");
        }

        public static void MethodTwo()
        {
            Console.WriteLine("MethodTwo");

        }

        public delegate void Del();

        static void Main(string[] args)
        {
            Del d = MethodOne;
            //adiciona mais um metodo ao delegate
            d += MethodTwo;
            //chama todos os metedos adicionados ao delegate
            d();
            //remove o metodo da lista, caso não exista esse metodo no delegate ele não irá retorna um exception
            d -= MethodOne;
            d();

            d += MethodOne;
            //Pega quantidade de metodo que está no delegate
            int count = d.GetInvocationList().GetLength(0);

            Console.WriteLine(count);

            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHierarchy_008
{
    class Program
    {
        static void Main(string[] args)
        {

            Base b = new Base();
            b.Execute();

            b = new Derived();
            b.Execute();
            //vai mostar a frase Base.Execute duas vezes
            //se tive-se colocado o metodo da classe base como virtual
            //e usa-se o override para sobreescrever o metodo isso não aconteceria
            Console.Read();

        }
    }
    class Base
    {
        public void Execute() { Console.WriteLine("Base.Execute"); }
    }

    class Derived : Base
    {
        public new void Execute() { Console.WriteLine("Derived.Execute"); }
    }
}

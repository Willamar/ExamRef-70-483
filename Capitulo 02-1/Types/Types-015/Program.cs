using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types_015
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Base
    {
        public virtual int MyMethod()
        {
            return 42;

        }

        
    }

    class Derived : Base
    {
        public sealed override int MyMethod()
        {
            return base.MyMethod() * 2;
        }
    }

    class Derived2 : Derived
    {
        //Aqui eu não consigo mas dar um override(sobreescrever) o metodo por causa da palavra sealed que pode também ser usada em classes,
        //onde a classe que for definida com a palavra chave sealed não pode ser herdada
    }

}

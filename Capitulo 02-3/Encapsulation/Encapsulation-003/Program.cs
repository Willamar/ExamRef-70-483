using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_003
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Base
    {
        private int _privateField = 42;
        protected int _protectedField = 42;

        private void MyPrivateMethod() { }
        protected void MyProtectedMethod()
        {
        }


    }

    public class Derived : Base
    {
        public void MyDerivedMethod()
        {
            // _private = 41; // Not Ok, this will generate a compile error
            _protectedField = 43; // ok, protected fields can be accessed

            // MyPrivateMethod(); // Not ok, this will generate a compile error
            MyProtectedMethod(); // ok, protected methods can be accessed
        }
    }
}

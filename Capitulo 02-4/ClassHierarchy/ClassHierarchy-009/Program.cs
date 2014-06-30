using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHierarchy_009
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    abstract class Base
    {
        public virtual void MethodWithImplementation() 
        {
            //Method with implementation 
        }

        public abstract void AbstractMethod();
    }

    class Derived : Base
    {
        public override void AbstractMethod()
        {
            
        }
    }
}

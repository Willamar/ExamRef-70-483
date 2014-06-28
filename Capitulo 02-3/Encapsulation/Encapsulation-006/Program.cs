using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_006
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    interface IInterfaceA
    {
        void MyMethod();
    }

    class Implementation : IInterfaceA
    {
        void IInterfaceA.MyMethod()
        {
        }
    }
}

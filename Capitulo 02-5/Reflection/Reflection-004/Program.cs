using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection_004
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class)]
    public class MyMethodAndParameterAttribute : Attribute
    {
    }

    [MyMethodAndParameter]
    class Person
    {
        [MyMethodAndParameter]
        void Method() { }
    }
}

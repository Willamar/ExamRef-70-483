using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection_003
{
    class Program
    {
        static void Main(string[] args)
        {
            ConditionalAttribute conditionalAttribute = (ConditionalAttribute)Attribute.GetCustomAttribute(
                typeof(Person), typeof(ConditionalAttribute));
            string condition = conditionalAttribute.ConditionString;

            Console.WriteLine(condition);

            Console.Read();
        }
    }

    class Person
    {
        [Conditional("CONDITION1")]
        void Method() { }
    }
}

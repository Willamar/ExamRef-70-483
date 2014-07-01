using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection_001
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    [Serializable]
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Conditional("CONDITION1"), Conditional("CONDITION2")] 
        static void MyMethod(){ }

    }
    
}

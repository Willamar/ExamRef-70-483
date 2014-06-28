using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_004
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class MyClass
    {
        private int _field;
        public void SetValue(int value) { _field = value; }
        public int GetValue() { return _field; }
    }

   
}

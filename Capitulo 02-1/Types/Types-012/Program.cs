using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types_012
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    class MyClass<T> where T : class, new()
    {
        T MyProperty { get; set; }
        public MyClass()
        {
            MyProperty = new T();
        }

        public void MyGenericMethod<T>()
        {
            T defaultValue = default(T);
        }
    }
}

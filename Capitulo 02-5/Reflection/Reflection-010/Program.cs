using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection_010
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 42;

            MethodInfo compareToMethod = i.GetType().GetMethod("CompareTo", new Type[] { typeof(int) });
            var result = compareToMethod.Invoke(i, new object[] { 40 });

            Console.WriteLine(result);

            Console.Read();
        }
    }
}

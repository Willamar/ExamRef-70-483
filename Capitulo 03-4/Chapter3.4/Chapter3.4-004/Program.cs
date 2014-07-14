using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3._4_004
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public Assembly LoadAssembly<T>()
        {
#if !WINRT
            Assembly assembly = typeof(T).Assembly;
#else
            Assembly assembly = typeof(T).GetTypeInfo().Assembly;
#endif
            return assembly;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollection_001
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class SomeType
    {
        ~SomeType()
        {
            //this code id called when the finalize method executes
        }
    }
}

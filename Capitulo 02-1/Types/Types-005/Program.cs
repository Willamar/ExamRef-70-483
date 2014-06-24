using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types_005
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        void MyMethod(int FirstArgument, string secondArgument = "default value", bool thirdArgument = false)
        {
        }

        void CallingMethod()
        {
            MyMethod(1, thirdArgument: true);
        }
        
    }
}

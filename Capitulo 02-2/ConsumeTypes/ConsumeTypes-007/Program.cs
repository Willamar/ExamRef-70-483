using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeTypes_007
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = Convert.ToInt32("42");
            value = int.Parse("42");
            bool sucess = int.TryParse("42", out value);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3._1_003
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "1";
            int result;

            bool sucess = int.TryParse(value, out result);

            if (sucess)
            {
                //Value is a valid integer, result contains the value
            }
            else
            {
                // value is not a valid integer
            }
        }
    }
}

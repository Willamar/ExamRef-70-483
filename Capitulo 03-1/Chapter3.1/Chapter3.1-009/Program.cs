using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Chapter3._1_009
{
    class Program
    {
        static void Main(string[] args)
        {
            RegexOptions options = RegexOptions.None;

            Regex regex = new Regex(@"[ ]{2,}", options);

            string input = "1 2 3 4  5";

            string result = regex.Replace(input, " ");

            Console.WriteLine(result);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter4._5_004
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfStrings = new List<string> { "A", "B", "C", "D", "E" };

            for (int x = 0; x < listOfStrings.Count; x++)
            {
                Console.Write(listOfStrings[x]);
            }

            listOfStrings.Remove("A");

            Console.WriteLine(listOfStrings[0]);

            listOfStrings.Add("F");

            Console.WriteLine(listOfStrings.Count);

            bool hasC = listOfStrings.Contains("C");

            Console.WriteLine(hasC);

            Console.Read();
        }
    }


}

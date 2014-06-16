using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_001
{
    class Program
    {
        static void Main(string[] args)
        {
            Check('a');
            cheWithSwitch('a');

            Console.Read();

        }
       

        static void Check(char input)
        {
            if (input == 'a'
                || input == 'e'
                || input == 'i'
                || input == 'o'
                || input == 'u')
            {
                Console.WriteLine("Input is a Vowel");
            }
            else
            {
                Console.WriteLine("Input is a consonant");
            }
        }
        static void cheWithSwitch(char input)
        {
            switch (input)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("Input is a vowel");
                    break;
                case 'y':
                    Console.WriteLine("Input is sometimes a vowel");
                    break;
                default:
                    Console.WriteLine("Input is a consonant");
                    break;
            }
        }
    }
}

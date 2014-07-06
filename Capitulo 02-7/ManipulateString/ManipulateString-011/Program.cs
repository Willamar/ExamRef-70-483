using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulateString_011
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Willamar", "Fernandes");

            Console.WriteLine(p);

            Console.Read();
        }
    }

    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public override string ToString()
        {

            return FirstName + " " + LastName;
        }
    }
}

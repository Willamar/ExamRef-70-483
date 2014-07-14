using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3._4_006
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person
            {
                FirstName = "Willamar",
                LastName = "Fernandes"
            };

            Console.Read();
        }
    }

    [DebuggerDisplay("Name = {FirstName} {LastName}" )]
    public class Person
    {
        public string FirstName { get; set; }
        public String LastName { get; set; }
    }
}

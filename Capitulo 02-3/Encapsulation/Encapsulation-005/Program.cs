using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_005
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Person
    {
        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException();
                }
                _firstName = value;
            }
        }
        //ou de forma abreviada

        public int Value { get; set; }
    }
}

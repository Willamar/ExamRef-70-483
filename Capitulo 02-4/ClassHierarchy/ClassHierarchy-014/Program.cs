using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHierarchy_014
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }

    class People : IEnumerable<Person>
    {
        Person[] people;
        public People(Person[] people)
        {
            this.people = people;
        }

        public IEnumerator<Person> GetEnumerator()
        {
            for (int index = 0; index < people.Length; index++)
            {
                yield return people[index];
            }
        }       
        //importa a namespace System.Colletions
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

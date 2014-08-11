using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter4._5_009
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person
            {
                FirstName = "Willamar",
                LastName = "Fernandes",
                Age = 23
            };

            Person p2 = new Person
            {
                FirstName = "Willian",
                LastName = "Fernandes",
                Age = 27
            };

            PeopleCollection people = new PeopleCollection { p1, p2 };
            people.RemoveByAge(27);
            Console.WriteLine(people.Count);

            Console.Read();
        }
    }

    public class PeopleCollection : List<Person>
    {
        public void RemoveByAge(int age)
        {
            for (int index = this.Count -1; index >= 0; index--)
            {
                if (this[index].Age == age)
                {
                    this.RemoveAt(index);
                }
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Person p in this)
            {
                sb.AppendFormat("{0} {1} is {2}", p.FirstName, p.LastName, p.Age);
            }
            return sb.ToString();
        }
    }

    public class Person
    {
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public int Age { get; set; }
    }

}

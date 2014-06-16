using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_009
{
    class Person
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }

        static void CannoChangeForeachIterationVariable()
        {
            var people = new List<Person>
            {
                new Person() { FirstName = "Willamar", LastName = "Fernandes"},
                new Person() { FirstName = "Willian", LastName = "Fernandes"}
            };

            foreach (Person p in people)
            {
                p.LastName = "Changed";
                //p = new Person(); // Isso ocorre um erro
            }
        }
    }
}

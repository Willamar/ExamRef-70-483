using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_010
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
            var people = new List<Person>
            {
                new Person() { FirstName = "Willamar", LastName = "Fernandes"},
                new Person() { FirstName = "Willian", LastName = "Fernandes"}
            };

            List<Person>.Enumerator e = people.GetEnumerator();

            try
            {
                Person v;
                while (e.MoveNext())
                {
                    v = e.Current;
                    Console.WriteLine(v.FirstName);
                }
            }
            finally
            {
                System.IDisposable d = e as System.IDisposable;
                if (d != null)
                {
                    d.Dispose();
                }
            }
            Console.Read();
        }
    }
}

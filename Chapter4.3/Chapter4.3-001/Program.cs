using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Chapter4._3_001
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Person));

            string xml;

            using (StringWriter sw = new StringWriter())
            {
                Person p = new Person
                {
                    FirstName = "Willamar",
                    LastName = "Fernandes",
                    Age = 23
                };

                serializer.Serialize(sw, p);
                xml = sw.ToString();
            }

            Console.WriteLine(xml);

            using (StringReader sr = new StringReader(xml))
            {
                //Person p = (Person)serializer.Deserialize(sr);
                Person p = serializer.Deserialize(sr) as Person;
                Console.WriteLine("{0} {1} is {2} years old", p.FirstName, p.LastName, p.Age);
            }

            Console.ReadKey();

        }
    }

    [Serializable]
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}

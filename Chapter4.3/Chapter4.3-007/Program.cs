using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Json;

namespace Chapter4._3_007
{
    class Program
    {
        static void Main(string[] args)
        {
            Person.SerializerPeson();
            Console.Read();
        }
    }


    [DataContract]
    public class Person
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public String Name { get; set; }

        public static void SerializerPeson()
        {
            Person p = new Person
            {
                Id = 1,
                Name = "Willamar Fernandes"
            };

            using (MemoryStream stream = new MemoryStream())
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Person));
                ser.WriteObject(stream, p);

                stream.Position = 0;
                StreamReader streamReader = new StreamReader(stream);
                Console.WriteLine(streamReader.ReadToEnd());

                stream.Position = 0;

                Person result = (Person)ser.ReadObject(stream);

                Console.WriteLine(result.Id);
                Console.WriteLine(result.Name);

            }


        }
    }
}

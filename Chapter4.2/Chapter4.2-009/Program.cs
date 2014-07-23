using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace Chapter4._2_009
{
    class Program
    {
        static void Main(string[] args)
        {
            StringWriter stream = new StringWriter();
            using (XmlWriter writer = XmlWriter.Create(stream, new XmlWriterSettings() { Indent = true }))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("People");
                writer.WriteStartElement("Person");
                writer.WriteAttributeString("firstName", "Willamar");
                writer.WriteAttributeString("lastName", "Fernandes");
                writer.WriteStartElement("ContactDetails");
                writer.WriteElementString("EmailAddress", "wfs20@hotmail.com");
                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.Flush();
            }

            Console.WriteLine(stream.ToString());

            Console.Read();

            Console.WriteLine();

            using (StringReader stringReader = new StringReader(stream.ToString()))
            {
                using (XmlReader xmlReader = XmlReader.Create(stringReader, new XmlReaderSettings() { IgnoreWhitespace = true }))
                {
                    xmlReader.MoveToContent();
                    xmlReader.ReadStartElement("People");

                    string firstName = xmlReader.GetAttribute("firstName");
                    string lastName = xmlReader.GetAttribute("lastName");

                    Console.WriteLine("Person: {0} {1}", firstName, lastName);
                    xmlReader.ReadStartElement("Person");

                    Console.WriteLine("ContactDetails");
                    xmlReader.ReadStartElement("ContactDetails");


                    string emailAddress = xmlReader.ReadString();

                    Console.WriteLine("Email address: {0}", emailAddress);


                    Console.ReadKey();

                }

            }

        }
    }
}

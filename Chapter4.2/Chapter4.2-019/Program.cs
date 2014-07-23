using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Chapter4._2_019
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument doc = XDocument.Parse(GetXml());

            IEnumerable<string> personNames = from p in doc.Descendants("Person")
                                              select (string)p.Attribute("firstName")
                                              + " " + (string)p.Attribute("lastName");

            foreach (string s in personNames)
            {
                Console.WriteLine(s);
            }

            Console.Read();
        }

        private static string GetXml()
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
                writer.WriteStartElement("Person");
                writer.WriteAttributeString("firstName", "john");
                writer.WriteAttributeString("lastName", "doe");
                writer.WriteStartElement("ContactDetails");
                writer.WriteElementString("EmailAddress", "john@unknow.com");
                writer.WriteEndElement();
                writer.WriteEndElement();

                writer.Flush();
            }

            return stream.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


namespace Chapter4._2_010
{
    class Program
    {
        static void Main(string[] args)
        {


            XmlDocument doc = new XmlDocument();

            doc.LoadXml(GetXml());

            XmlNodeList nodes = doc.GetElementsByTagName("Person");

            foreach (XmlNode node in nodes)
            {
                string firstName = node.Attributes["firstName"].Value;
                string lastName = node.Attributes["lastName"].Value;

                Console.WriteLine("Name: {0} {1}", firstName, lastName);
            }

            //Start creating a new node

            XmlNode newNode = doc.CreateNode(XmlNodeType.Element, "Person", "");

            XmlAttribute firstNameAttribute = doc.CreateAttribute("firstName");
            firstNameAttribute.Value = "Foo";

            XmlAttribute lastNameAttribute = doc.CreateAttribute("lastName");
            lastNameAttribute.Value = "Bar";

            newNode.Attributes.Append(firstNameAttribute);
            newNode.Attributes.Append(lastNameAttribute);

            doc.DocumentElement.AppendChild(newNode);

            Console.WriteLine("Modified xml...");

            doc.Save(Console.Out);

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
                writer.Flush();
            }

            return stream.ToString();

        }

    }
}

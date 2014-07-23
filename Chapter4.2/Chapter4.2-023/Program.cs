using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Chapter4._2_023
{
    class Program
    {
        static void Main(string[] args)
        {
            XElement root = XElement.Parse(GetXml());

            XElement newTree = new XElement("People",
                from p in root.Descendants("Person")
                let name = (string)p.Attribute("firstName") + (string)p.Attribute("lastName")
                let contactDetails = p.Element("ContactDetails")
                select new XElement("Person",
                    new XAttribute("IsName", name.Contains("john")),
                    p.Attributes(),
                    new XElement("ContactDetails",
                        contactDetails.Element("EmailAddress"),
                        contactDetails.Element("PhoneNumber")
                            ?? new XElement("PhoneNumber", "1122334455")
            )));

            
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
                writer.WriteElementString("PhoneNumber", "001122334455");
                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.Flush();
            }

            return stream.ToString();

        }
    }
}

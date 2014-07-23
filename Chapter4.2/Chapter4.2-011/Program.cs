using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.XPath;

namespace Chapter4._2_011
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(GetXml());

            XPathNavigator nav = doc.CreateNavigator();

            string query = "//People/Person[@firstName='Willamar']";
            XPathNodeIterator iterator = nav.Select(query);

            while(iterator.MoveNext())
            {
                string firstName = iterator.Current.GetAttribute("firstName", "");
                string lastName = iterator.Current.GetAttribute("lastName", "");
                Console.WriteLine("Name: {0} {1}", firstName, lastName);
            }
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

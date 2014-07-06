using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ManipulateString_004
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringWriter = new StringWriter();

            using (XmlWriter writer = XmlWriter.Create(stringWriter))
            {
                writer.WriteStartElement("book");
                writer.WriteElementString("price", "19.95");
                //writer.WriteElement();
                writer.Flush();
            }

            string xml = stringWriter.ToString();

            Console.WriteLine(xml);

            Console.Read();
        }
    }
}

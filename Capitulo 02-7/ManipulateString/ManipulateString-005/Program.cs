﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ManipulateString_005
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

            var stringReader = new StringReader(xml);

            using (XmlReader reader = XmlReader.Create(stringReader))
            {
                reader.ReadToFollowing("price");
                decimal price = decimal.Parse(reader.ReadInnerXml(), new CultureInfo("en-US")); // make sure that you read the decimal part correctly

                Console.WriteLine(price);
            }
            Console.Read();
        }

    }
}

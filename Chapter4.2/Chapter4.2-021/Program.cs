using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Chapter4._2_021
{
    class Program
    {
        static void Main(string[] args)
        {
            XElement root = new XElement("Root",
                new List<XElement>
                {
                    new XElement("child1"),
                    new XElement("child2"),
                    new XElement("child3")
                },
                new XAttribute("MyAttribute", 42));

            root.Save("test.xml");



        }
    }
}

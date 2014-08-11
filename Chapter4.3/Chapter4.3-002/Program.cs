using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Chapter4._3_002
{
    class Program
    {
        static void Main(string[] args)
        {


           XmlSerializer serializer = new XmlSerializer(typeof(Order), new Type[] { typeof(VIPOrder) });

          

            string xml;

            using (StringWriter sw = new StringWriter())
            {
                Order order = CreateOrder();

                serializer.Serialize(sw, order);

                xml = sw.ToString();
            }

            Console.WriteLine(xml);

            Console.Read();

        }

        private static Order CreateOrder()
        {
            Product p1 = new Product { ID = 1, Description = "p1", Price = 9 };
            Product p2 = new Product { ID = 2, Description = "p2", Price = 6 };

            Order order = new VIPOrder
            {
                ID = 4,
                Description = "Order for Willamar Fernandes. Use the nice giftwrap",
                OrderLines = new List<OrderLine>
                {
                    new OrderLine { ID = 5, Amount = 1, Product = p1},
                    new OrderLine { ID = 6, Amount = 10, Product = p2}
                }               
            };

            return order;
        }
    }

    

    [Serializable]
    public class Product
    {
        [XmlAttribute]
        public int ID { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        public Product()
        {
        }
    }

    [Serializable]
    public class OrderLine
    {
        [XmlAttribute]
        public int ID { get; set; }

        [XmlAttribute]
        public int Amount { get; set; }

        [XmlElement("OrderedProduct")]
        public Product Product { get; set; }

        public OrderLine()
        {
        }
    }

    [Serializable]
    public class Order
    {

        [XmlAttribute]
        public int ID { get; set; }

        [XmlIgnore]
        public bool IsDirty { get; set; }

        [XmlArray("Lines")]
        [XmlArrayItem("OrderLine")]
        public List<OrderLine> OrderLines { get; set; }

        public Order()
        {
        }
    }

    [Serializable]
    public class VIPOrder : Order
    {
        public string Description { get; set; }

        public VIPOrder()
        {
        }
    }
}

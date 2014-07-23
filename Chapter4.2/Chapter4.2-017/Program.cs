using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4._2_017
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            string[] popularProductsNames = { "A", "B" };

            var popularProducts = from p in products
                                  join n in popularProductsNames on p.Description equals n
                                  select p;
        }
    }

    public class Product
    {
        public string Description { get; set; }
        public string Price { get; set; }

    }

    public class OrderLine
    {
        public int Amount { get; set; }
        public Product Product { get; set; }
    }

    public class Order
    {
        public List<OrderLine> OrderLines { get; set; }
    }
}

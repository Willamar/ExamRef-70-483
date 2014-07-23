using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4._2_016
{
    class Program
    {
        static void Main(string[] args)
        {


            List<Order> orders = new List<Order>();

            var result = from o in orders
                         from l in o.OrderLines
                         group l by l.Product into p
                         select new
                         {
                             Product = p.Key,
                             Amount = p.Sum(x => x.Amount)
                         };
           
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

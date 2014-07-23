using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4._2_018
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Order> orders = new List<Order>();
            int pageIndex = 2;
            int pageSize = 20;


            var pagedOrders = orders
                            .Skip((pageIndex - 1) * pageSize)
                            .Take(pageSize);

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

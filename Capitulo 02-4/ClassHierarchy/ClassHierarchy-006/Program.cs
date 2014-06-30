using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHierarchy_006
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    interface IEntity
    {
        int Id { get; }
    }

    class Repositoty<T> where T : IEntity
    {
        protected IEnumerable<T> _elements;

        public Repositoty(IEnumerable<T> elements)
        {
            _elements = elements;
        }

        public T FindById(int id)
        {
            return _elements.SingleOrDefault(e => e.Id == id);
        }
    }

    class Order : IEntity
    {
        public int Id { get; set; }
    }

    class OrderRepository : Repositoty<Order>
    {
        public OrderRepository(IEnumerable<Order> orders)
            :base (orders)
        {
        }

        public IEnumerable<Order> FilterOrderOnAmount(decimal amount)
        {
            List<Order> result = null;
            //some fitering cod

            return result;
        }
    }
}

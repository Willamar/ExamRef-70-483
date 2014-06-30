using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHierarchy_005
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
}

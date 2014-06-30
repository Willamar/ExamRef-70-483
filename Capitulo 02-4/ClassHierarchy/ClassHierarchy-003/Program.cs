using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHierarchy_003
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    interface IRepository<T>
    {
        T FindById(int id);
        IEnumerable<T> All();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3._2_005
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Set<T>
    {
        private List<T> list = new List<T>();

        public void Insert(T item)
        {
            if (!Contains(item))
            {
                list.Add(item);
            }
        }

        public bool Contains(T item)
        {
            foreach (T member in list)
            {
                if (member.Equals(item))
                {
                    return true;
                }
            }
            return false;
        }


    }
}

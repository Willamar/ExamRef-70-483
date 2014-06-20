using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_002
{
    public class Pub
    {
        public event Action OnChange = delegate { };

        public void Raise()
        {
            OnChange();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pub p = new Pub();
            p.OnChange += () => Console.WriteLine("Method 1");
            p.OnChange += () => Console.WriteLine("Method 2");
            p.Raise();

            Console.Read();

        }

        
    }
}

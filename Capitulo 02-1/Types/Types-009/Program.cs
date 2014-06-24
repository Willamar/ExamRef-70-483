using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types_009
{
    class Program
    {
        static void Main(string[] args)
        {
            ConstructorChaining c = new ConstructorChaining();
            ConstructorChaining c2 = new ConstructorChaining(4);

        }
    }

    class ConstructorChaining
    {
        private int _p;

        public ConstructorChaining() : this(3) { }
        
        public ConstructorChaining(int p)
        {
            this._p = p;
        }

    }
}

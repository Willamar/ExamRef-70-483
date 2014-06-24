using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types_010
{
    struct teste
    {
        public teste(int i)
        {
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            teste t2 = new teste();
            Nullable<teste> t = new Nullable<teste>(t2);
            Console.WriteLine(t.HasValue);
            Console.Read();
        }
    }

    struct Nullable<T> where T : struct
    {
        private bool hasValue;
        private T value;

        public Nullable(T value)
        {
            this.hasValue = true;
            this.value = value;
        }

        public bool HasValue { get { return this.hasValue; } }

        public T Value
        {
            get
            {
                if (!this.hasValue)
                {
                    throw new ArgumentException();

                }
                return this.value;
            }
        }

        public T GetValuesOrDefault()
        {
            return this.value;
        }
    }
}

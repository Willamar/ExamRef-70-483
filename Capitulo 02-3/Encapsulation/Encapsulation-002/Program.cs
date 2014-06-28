using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_002
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Accessibility
    {
        // initialization code and error cheking omitted
        private string[] _myField;

        public string MyProperty
        {
            get { return _myField[0]; }
            set { _myField[0] = value; }
        }
    }
}

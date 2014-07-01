using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection_002
{
    class Program
    {
        static void Main(string[] args)
        {
            if (Attribute.IsDefined(typeof(Animal), typeof(SerializableAttribute))) 
            {
                Console.WriteLine("O Atributo Serializable foi definido na class Animal");
            }
        }
    }
    [Serializable]
    class Animal
    {

    }

}

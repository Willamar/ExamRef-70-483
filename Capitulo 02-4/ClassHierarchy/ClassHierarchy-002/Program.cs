using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHierarchy_002
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    interface IReadOnlyInterface
    {
        int Value { get; }
    }

    struct ReadAndWriteImplementation : IReadOnlyInterface
    {
        public int Value { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHierarchy_001
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    interface IExample
    {
        //nenhum modificador de acesso, pq por padrão todos os elementos são publicos
        string GetResult();
        int Value { get; set; }
        event EventHandler ResultRetrieved;
        int this[string index] { get; set; }
    }

    class ExempleImplentation : IExample
    {
        //aqui temos que colocar os modificadores de acesso(public)
        public string GetResult()
        {
            return "result";
        }

        public int Value { get; set; }

        public event EventHandler ResultRetrieved;

        public int this[string index]
        {
            get
            {
                return 42;
            }
            set { }
        }

        public event EventHandler CalculationPerformed;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeTypes_006
{
    class Program
    {
        static void Main(string[] args)
        {
            Money m = new Money(42.42m);
            decimal amount = m;
            int trucatedAmount = (int)m;
        }
    }

    class Money
    {
        public decimal Amount { get; set; }

        public Money(decimal amount)
        {
            Amount = amount;
        }
        //Conversão implicita, usnado as palavras-chaves static e implicit
        public static implicit operator decimal(Money money)
        {
            return money.Amount;
        }
        //Conversão explicita, usando as palavras-chaves explicit e static
        public static explicit operator int(Money money)
        {
            return (int)money.Amount;
        }

        //os metodos devem ser publicos, staticos e usando a palavra chave, implicit ou explicit
    }
}

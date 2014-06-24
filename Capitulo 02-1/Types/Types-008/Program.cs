using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types_008
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Deck
    {
        private int _maximumNumberOdCards;

        public List<Card> Cards { get; set; }

        public Deck(int maximumNumberOfCards)
        {
            this._maximumNumberOdCards = maximumNumberOfCards;
            Cards = new List<Card>();
        }
    }
}

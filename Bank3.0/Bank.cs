using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Bank3._0
{
    internal class Bank
    {
        private List<Card> _cards;

        public Bank()
        {
            _cards = new List<Card>
            {
                new Card("1111", "0000", 1000),
                new Card("2222", "1234", 50000)
             };
        }

        public Card GetCard(string number)
        {
            return _cards.FirstOrDefault(card => card.Number == number);
        }
    }
}

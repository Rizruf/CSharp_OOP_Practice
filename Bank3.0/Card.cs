using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank3._0
{
    internal class Card
    {
        public string Number { get; private set; }
        public string Pin { get; private set; }
        public decimal Balance { get; private set; }

        public Card(string number, string pin, decimal balance)
        {
            Number = number;
            Pin = pin;
            Balance = balance;
        }

        private bool IsAmountValid(decimal amount)
        {
            const decimal moneyBorder = 50;
            const int multiplicity = 10;

            if (amount % multiplicity != 0) return false;
            if (amount < moneyBorder) return false;

            return true;
        }

        public bool Deposit(decimal amount)
        {
            if (IsAmountValid(amount))
            {
                Balance += amount;
                return true;
            }
            return false;
        }

        public bool Withdraw(decimal amount)
        {
            if (!IsAmountValid(amount)) return false;

            if (Balance < amount) return false;

            Balance -= amount;
            return true;
        }

        public bool CheckPin(string inputPin)
        {
            return Pin == inputPin;
        }
    }
}

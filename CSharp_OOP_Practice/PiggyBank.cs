using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_OOP_Practice
{
    internal class PiggyBank
    {
        private int _money = 0;

        public void AddMoney(int setMoney)
        {
            Console.WriteLine("Положили в копилку денег - " + setMoney);
            _money += setMoney;
        }

        public void BreakPeaggy()
        {
            Console.WriteLine("Копилку разбили! Денег выпало - " + _money);

            _money = 0;
        }
    }
}

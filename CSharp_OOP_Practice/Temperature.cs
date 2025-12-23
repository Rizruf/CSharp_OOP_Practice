using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_OOP_Practice
{
    internal class Temperature
    {
        private int celsius;

        public int Celsius_Сheck
        {
            get { return celsius; }

            set
            {
                if (value < -273)
                {
                    Console.WriteLine("Ошибка: Температура ниже абсолютного нуля!");
                }
                else celsius = value;
            }
        }

        public int Fahrenheit
        {
            get { return (celsius * 9 / 5) + 32; }
        }
    }
}

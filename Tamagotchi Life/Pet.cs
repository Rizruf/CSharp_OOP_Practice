using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi_Life
{
    internal class Pet
    {
        private int _health = 100;
        private int _hanger = 0;
        private int _fatigue = 0;
        private int _joy = 0;

        public bool Info()
        {
            if (_health == 100) Console.WriteLine("Ваш питомец абсолютно здоров!");
            else if (_health <= 50 && _health >= 30) Console.WriteLine("Питомцу нужен уход!");
            else if (_health < 30 && _health != 0) Console.WriteLine("Питомцу нужен уход срочно!");
            else if (_health == 0)
            {
                Console.WriteLine("Вы проиграли!");
                return false;
            }

            if (_hanger >= 5) Console.WriteLine("Питомец не голоден!");
            else Console.WriteLine("Питомец не голоден!");

            if (_fatigue < 5) Console.WriteLine("Питомец не уставший!");
            else Console.WriteLine("Питомец не голоден!");

            if (_joy > 5) Console.WriteLine("Питомец счастлив!");
            else Console.WriteLine("Питомец грустит!");

            return true;
        }

        public void Feed()
        {
            if (_hanger >= 5 && _hanger != 0)
            {
                Console.WriteLine("Питомец сейчас не голоден!");
            }
            else if (_hanger == 0) _health -= 30;
            else
            {
                Console.WriteLine("Вы кормите митомца и он становится игривым! Стоит с ним поиграть!");
                if (_health != 100 && _health != 0)
                {
                    _health += 20;
                    if (_health > 100) _health = 100;
                }
                _hanger = 0;
                _joy += 1;
            }
        }
        
        public void Play()
        {
            Console.WriteLine("Вы играете с питомцем, он устал!");
            _fatigue += 6;
            if (_fatigue == 10)
            {
                _health -= 30;
            }
            else
            {

            }
        }
        
        public void Sleep()
        {

        }

    }
}

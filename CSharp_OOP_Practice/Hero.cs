using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_OOP_Practice
{
    internal class Hero
    {
        private int _health = 100;

        public void Hit(int dmg)
        {
            _health -= dmg;

            if (_health <= 0)
            {
                _health = 0;
                Console.WriteLine("Убило");
            }
            else
            {
                Console.WriteLine($"Получен урон: {dmg}. Осталось HP: {_health}");
            }
        }


        public void Attack()
        {
            Console.WriteLine("Удар кулаком");
        }
        public void Attack(string weapon)
        {
            Console.WriteLine("Удар оружием - " + weapon);
        }
        public void Attack(string magic, string mana)
        {
            Console.WriteLine("Удар магией - " + magic + "c использованием типа маны - " + mana);
        }
    }
}

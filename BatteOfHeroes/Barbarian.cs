using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteOfHeroes
{
    internal class Barbarian : Unit
    {
        public Barbarian(string name, int health, int damage, int armor)
            : base (name, health, damage, armor)
        {
           
        }

        public override void Attack(Unit target)
        {
            int axeDamage = 15;

            int throwAxe = Damage + 15;

            if (new Random().Next(0, 100) < 10)
            {
                Console.WriteLine($"Варвар еще и кинул топор! Дополнительный урон - {axeDamage}");
                target.TakeDamage(throwAxe);
            }
            else base.Attack(target);
        }
    }
}

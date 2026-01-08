using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteOfHeroes
{
    internal class Warrior : Unit
    {
        public Warrior(string name, int health, int damage, int armor)
        : base(name, health, damage, armor)
        {

        }

        public override void Attack(Unit target)
        {
            int doubleDamage = Damage * 2;

            if (new Random().Next(0, 100) < 30)
            {
                Console.WriteLine("КРИТ! Двойной удар!");
                base.TakeDamage(doubleDamage);
            }
            else base.Attack(target);
        }
    }
}

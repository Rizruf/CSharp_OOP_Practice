using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteOfHeroes
{
    internal class Mage : Unit
    {
        public Mage(string name, int health, int damage, int armor)
            : base(name, health, damage, armor)
        {

        }

        public override void Attack(Unit target)
        {
            base.Attack(target);

            int pureDamage = Damage;
            target.TakeDamage(pureDamage);
            Console.WriteLine($"Маг прожег броню! Урон: {pureDamage}");
        }

        
    }
}

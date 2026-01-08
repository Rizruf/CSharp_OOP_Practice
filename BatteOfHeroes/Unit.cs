using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BatteOfHeroes
{
    internal class Unit
    {
        public string Name { get; private set; }
        public int Health { get; private set; }
        public int Damage { get; private set; }
        public int Armor { get; private set; }

        public Unit(string name, int health, int damage, int armor)
        {
            Name = name;
            Health = health;
            Damage = damage;
            Armor = armor;
        }

        public virtual void Attack(Unit target)
        {
            int damageDealt = Damage - target.Armor;

            if (damageDealt <= 0) damageDealt = 1;
            
            target.TakeDamage(damageDealt);

            Console.WriteLine($"{Name} атаковал {target.Name} на {damageDealt} урона.");
        }

        public void TakeDamage(int dmg)
        {
            Health -= dmg;

            if (Health < 0) Health = 0;
        }
    }
}

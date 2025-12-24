using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_OOP_Practice
{
    internal class Hero
    {
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_OOP_Practice
{
    internal class Animal
    {
        public virtual void Voice()
        {
            Console.WriteLine("... тишина ...");
        }
    }
    internal class Dog : Animal
    {
        public override void Voice()
        {
            Console.WriteLine("... гав ...");
        }
    }

    internal class Cat : Animal
    {
        public override void Voice()
        {
            Console.WriteLine("... мяу ...");
        }
    }

    internal class Tiger : Animal
    {
        public override void Voice()
        {
            Console.WriteLine("... РРРРР ...");
        }
    }
}

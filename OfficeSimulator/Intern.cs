using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeSimulator
{
    internal class Intern : Employee
    {
        public Intern(string name)
            : base(name) { }

        public override void Work()
        {
            Console.WriteLine("Носит кофе и боится сломать прод");
        }
    }
}

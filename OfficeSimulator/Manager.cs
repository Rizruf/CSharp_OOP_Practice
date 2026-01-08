using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeSimulator
{
    internal class Manager : Employee
    {
        public Manager(string name)
            : base(name) { }

        public override void Work()
        {
            Console.WriteLine("Проводит митинг и орет на всех");
        }
    }
}

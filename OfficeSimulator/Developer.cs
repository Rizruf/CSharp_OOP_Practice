using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeSimulator
{
    internal class Developer : Employee
    {
        public Developer(string name)
            : base(name) { }

        public override void Work()
        {
            Console.WriteLine("Пишет код и матерится на легаси");
        }
    }
}

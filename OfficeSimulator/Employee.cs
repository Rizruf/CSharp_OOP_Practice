using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OfficeSimulator
{
    internal class Employee
    {
        public string Name {  get; private set; }

        public Employee(string name)
        {
            Name = name;
        }

        public virtual void Work()
        {
            Console.WriteLine($"{Name} Пьет кофе.");
        }
    }
}

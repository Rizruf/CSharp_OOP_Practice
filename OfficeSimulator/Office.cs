using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeSimulator
{
    internal class Office
    {
        private List<Employee> _employees;

        public Office()
        {
            _employees = new List<Employee>();
        }

        public void Add (Employee employee)
        {
            _employees.Add(employee);
        }

        public void StartWorkDay()
        {
            foreach (Employee employee in _employees)
            {
                Console.Write($"{employee.Name}: ");
                employee.Work();
            }
        }


    }
}

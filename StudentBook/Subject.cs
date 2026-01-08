using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentBook
{
    internal class Subject
    {
        public string Name { get; private set; }
        public int Grade { get; private set; }

        public Subject(string name, int grade)
        {
            Name = name;
            Grade = grade;
        }


    }
}

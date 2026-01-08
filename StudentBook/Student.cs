using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentBook
{
    internal class Student
    {
        public string Name { get; private set; }
        
        private List<Subject> _recordBook;
        
        public Student(string name)
        {
            Name = name;
            _recordBook = new List<Subject>();
        }

        public void Add(string subjectName, int grade)
        {
            Subject newSubject = new Subject(subjectName, grade);
            _recordBook.Add(newSubject);
        }

        public void PrintInfo()
        {
            double sum = 0;

            foreach (Subject subjectGrade in _recordBook)
            {
                Console.WriteLine($"{subjectGrade.Name}: {subjectGrade.Grade}");
                sum += subjectGrade.Grade;
            }

            if (_recordBook.Count > 0)
            {
                double average = sum / _recordBook.Count;
                Console.WriteLine($"Средний балл: {average:F2}");
            }
            else
            {
                Console.WriteLine("Зачетка пуста.");
            }
        }
    }
}

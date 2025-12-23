using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_OOP_Practice
{
    internal class Passport
    {
        private string FIO;
        private string Number;
        private DateOnly IssueDate;

        public Passport(string fio, string number, DateOnly data)
        {
            FIO = fio;
            Number = number;
            IssueDate = data;
        }

        public void Print_Info()
        {
            Console.WriteLine($"{FIO} || {Number} || {IssueDate}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_OOP_Practice
{
    internal class Book
    {
        public string Title { get; private set; }
        public string Author { get; private set; }

        public Book(string t, string a)
        {
            Title = t;
            Author = a; 
        }
    }
}

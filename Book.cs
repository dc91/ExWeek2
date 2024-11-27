using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExWeek2
{
    internal class Book
    {
        string Author {  get; set; }
        string Name { get; set; }
        int Pages { get; set; }

        public Book(string author, string name, int pages) 
        {
            Author = author;
            Name = name;
            Pages = pages;
        }

        public string Print()
        {
            return $"{Author}, {Name}, {Pages}";
        }

    }
}

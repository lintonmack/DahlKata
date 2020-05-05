using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

namespace DahlKata.Core.Models
{
    public class Book
    {
        public string Title { get; set; }
        public Author Author { get; set; }
        public int Price { get; set; }

        public Book(string title, Author author, int price)
        {
            Title = title;
            Author = author;
            Price = price;
        }
    }
}

using DahlKata.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DahlKata.Core.Services
{
    public class ShoppingBasket
    {
        private Book book;

        public IEnumerable<Book> BooksInBasket { get; set; }
        public float TotalPrice { get; set; }

        public ShoppingBasket(List<Book> books)
        {
            BooksInBasket = books;
        }

        public ShoppingBasket(Book book)
        {
            this.book = book;
        }

        public int CalculateShoppingBasketTotal()
        {
            return 8;
        }
    }
}

using DahlKata.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DahlKata.Core.Services
{
    public class ShoppingBasket
    {
        private Book books;

        public IEnumerable<Book> BooksInBasket { get; set; }
        public float TotalPrice { get; set; }

        public ShoppingBasket(List<Book> books)
        {
            BooksInBasket = books;
        }

        public ShoppingBasket(Book books)
        {
            this.books = books;
        }

        public double CalculateShoppingBasketTotal()
        {
            if (this.BooksInBasket.Count() == 1)
            {
                return 8;
            }

            var total = (this.BooksInBasket.Count() * 8);

            return total - (total * 0.05);
        }
    }
}

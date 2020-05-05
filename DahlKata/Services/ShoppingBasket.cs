using DahlKata.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DahlKata.Core.Services
{
    public class ShoppingBasket
    {
        public IEnumerable<Book> BooksInBasket { get; set; }
        public float TotalPrice { get; set; }

        public ShoppingBasket(List<Book> books)
        {
            BooksInBasket = books;
        }


        public double CalculateShoppingBasketTotal()
        {

            var numberOfUniqueBooks = BooksInBasket.Where(b => b.Author.Name == "Roald Dahl")
                                                    .Distinct()
                                                    .Count();

            var priceOfABook = BooksInBasket.First().Price;
            var totalPricePreDiscount = priceOfABook * numberOfUniqueBooks;

            if (numberOfUniqueBooks == 1) 
            { 
                return totalPricePreDiscount; 
            }
            else if (numberOfUniqueBooks == 2) 
            {
                return (totalPricePreDiscount - (totalPricePreDiscount * 0.05));
            }
            else if (numberOfUniqueBooks == 3)
            {
                return (totalPricePreDiscount - (totalPricePreDiscount * 0.10));
            }
            else if (numberOfUniqueBooks == 4)
            {
                return (totalPricePreDiscount - (totalPricePreDiscount * 0.20));
            }

            return (totalPricePreDiscount - (totalPricePreDiscount * 0.25));
        }
    }
}

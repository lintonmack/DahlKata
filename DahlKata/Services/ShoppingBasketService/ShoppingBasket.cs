using DahlKata.Core.Models;
using DahlKata.Core.Services.BookSortService.NonRoaldDahlBookService;
using DahlKata.Core.Services.PriceGeneratorService.NonRoaldDahlPriceGeneratorService;
using DahlKata.Core.Services.PriceGeneratorService.RoaldDahlPriceGeneratorService;
using DahlKata.Core.Services.RoaldDahlBookSortService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DahlKata.Core.Services.ShoppingBasketService
{
    public class ShoppingBasket
    {
        private readonly IRoaldDahlBookSort _roaldDahlBookSort;
        private readonly INonRoaldDahlBookSort _nonRoaldDahlBookSort;
        private readonly IRoaldDahlPriceGenerator _roaldDahlPriceGenerator;
        private readonly INonRoaldDahlPriceGenerator _nonRoaldDahlPriceGenerator;

        public IEnumerable<Book> BooksInBasket { get; set; }
        public float TotalPrice { get; set; }

        public ShoppingBasket(List<Book> books, 
            IRoaldDahlBookSort roaldDahlBookSort, 
            INonRoaldDahlBookSort nonRoaldDahlBookSort, 
            IRoaldDahlPriceGenerator roaldDahlPriceGenerator,
            INonRoaldDahlPriceGenerator nonRoaldDahlPriceGenerator)
        {
            BooksInBasket = books;
            _roaldDahlBookSort = roaldDahlBookSort;
            _nonRoaldDahlBookSort = nonRoaldDahlBookSort;
            _roaldDahlPriceGenerator = roaldDahlPriceGenerator;
            _nonRoaldDahlPriceGenerator = nonRoaldDahlPriceGenerator;
        }

        public double CalculateShoppingBasketTotal()
        {
            var priceOfABook = BooksInBasket.First().Price;
            var numberOfRoaldDahlUniqueBooks = _roaldDahlBookSort.GetNumberOfRoaldDahlBooks(BooksInBasket);
            var numberOfNonRoaldDahlBooks = _nonRoaldDahlBookSort.GetNumberOfNonRoaldDahlBooks(BooksInBasket);
            var totalPriceOfRoaldDahlBooks = _roaldDahlPriceGenerator.GetTotalPrice(numberOfRoaldDahlUniqueBooks, priceOfABook);
            var totalPriceOfNonRoaldDahlBooks = _nonRoaldDahlPriceGenerator.GetTotalPrice(numberOfNonRoaldDahlBooks, priceOfABook);

            return totalPriceOfRoaldDahlBooks + totalPriceOfNonRoaldDahlBooks;
        }
    }
}

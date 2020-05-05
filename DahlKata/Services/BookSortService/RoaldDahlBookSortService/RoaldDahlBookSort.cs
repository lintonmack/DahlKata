using DahlKata.Core.Models;
using DahlKata.Core.Services.RoaldDahlBookSortService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DahlKata.Core.Services.BookSortService.RoaldDahlBookSortService
{
    public class RoaldDahlBookSort : IRoaldDahlBookSort
    {
        public int GetNumberOfRoaldDahlBooks(IEnumerable<Book> booksInBasket)
        {
            var numberOfUniqueBooks = booksInBasket.Where(b => b.Author.Name == "Roald Dahl")
                                                    .Distinct()
                                                    .Count();

            return numberOfUniqueBooks;
        }
    }
}

using DahlKata.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DahlKata.Core.Services.BookSortService.NonRoaldDahlBookService
{
    public class NonRoaldDahlBookSort : INonRoaldDahlBookSort
    {
        public int GetNumberOfNonRoaldDahlBooks(IEnumerable<Book> booksInBasket)
        {
            var numberOfUniqueBooks = booksInBasket.Where(b => b.Author.Name != "Roald Dahl")
                                                    .Distinct()
                                                    .Count();

            return numberOfUniqueBooks;
        }
    }
}

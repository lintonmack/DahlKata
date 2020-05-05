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
        /*
     * Used to select the number of unique Roald Dahl Books
     * ToDo: Change the name of the class to be more meaning full.
     */
        public int GetNumberOfRoaldDahlBooks(IEnumerable<Book> booksInBasket)
        {
            var numberOfUniqueBooks = booksInBasket.Where(b => b.Author.Name == "Roald Dahl")
                                                    .Distinct()
                                                    .Count();

            return numberOfUniqueBooks;
        }
    }
}

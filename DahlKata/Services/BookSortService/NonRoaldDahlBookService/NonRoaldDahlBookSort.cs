using DahlKata.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DahlKata.Core.Services.BookSortService.NonRoaldDahlBookService
{
    /*
     * Used to select the number of unique Non Roald Dahl Books
     * ToDo: Change the name of the class to be more meaning full.
     */
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

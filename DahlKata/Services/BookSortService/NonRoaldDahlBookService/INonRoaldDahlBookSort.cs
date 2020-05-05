using DahlKata.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DahlKata.Core.Services.BookSortService.NonRoaldDahlBookService
{
    public interface INonRoaldDahlBookSort
    {
        int GetNumberOfNonRoaldDahlBooks(IEnumerable<Book> booksInBasket);
    }
}

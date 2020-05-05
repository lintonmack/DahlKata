using DahlKata.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DahlKata.Core.Services.RoaldDahlBookSortService
{
    public interface IRoaldDahlBookSort
    {
        int GetNumberOfRoaldDahlBooks(IEnumerable<Book> booksInBasket);
    }
}

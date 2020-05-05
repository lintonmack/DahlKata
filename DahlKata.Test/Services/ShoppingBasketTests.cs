using DahlKata.Core.Services;
using DahlKata.Core.Models;
using Xunit;
using System.Collections.Generic;
using FluentAssertions;

namespace DahlKata.Test.Services
{
    public class ShoppingBasketTests
    {
        [Fact]
        public void ShouldReturnNoDiscountForOneBook()
        {
            // Arrange
            var author = new Author("Roald Dahl");

            var book = new List<Book>
            {
                new Book("Matilda", author, 8)
            };

            var subject = new ShoppingBasket(book);

            // Act
            var result = subject.CalculateShoppingBasketTotal();

            // Assert
            result.Should().Be(8);
        }

    }
}

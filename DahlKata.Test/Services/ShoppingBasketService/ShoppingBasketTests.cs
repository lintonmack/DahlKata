using DahlKata.Core.Models;
using Xunit;
using System.Collections.Generic;
using FluentAssertions;
using DahlKata.Core.Services.ShoppingBasketService;
using Moq;
using DahlKata.Core.Services.RoaldDahlBookSortService;
using DahlKata.Core.Services.BookSortService.NonRoaldDahlBookService;
using DahlKata.Core.Services.PriceGeneratorService.RoaldDahlPriceGeneratorService;
using DahlKata.Core.Services.PriceGeneratorService.NonRoaldDahlPriceGeneratorService;
using DahlKata.Core.Services.BookSortService.RoaldDahlBookSortService;

namespace DahlKata.Test.Services.ShoppingBasketService
{
    public class ShoppingBasketTests
    {
        private readonly IRoaldDahlBookSort _roaldDahlbookSort;
        private readonly INonRoaldDahlBookSort _nonRoaldDahlBookSort;
        private readonly IRoaldDahlPriceGenerator _roaldDahlPriceGenerator;
        private readonly INonRoaldDahlPriceGenerator _nonRoaldDahlPriceGenerator;


        public ShoppingBasketTests()
        {
            _nonRoaldDahlBookSort = new NonRoaldDahlBookSort();
            _roaldDahlbookSort = new RoaldDahlBookSort();
            _nonRoaldDahlPriceGenerator = new NonRoaldDahlPriceGenerator();
            _roaldDahlPriceGenerator = new RoaldDahlPriceGenerator();
        }


        [Fact]
        public void ShouldReturnNoDiscountForOneBook()
        {
            // Arrange
            var author = new Author("Roald Dahl");

            var book = new List<Book>
            {
                new Book("Matilda", author, 8)
            };

            var subject = new ShoppingBasket(book,
                _roaldDahlbookSort,
                _nonRoaldDahlBookSort,
                _roaldDahlPriceGenerator,
                _nonRoaldDahlPriceGenerator);

            // Act
            var result = subject.CalculateShoppingBasketTotal();

            // Assert
            result.Should().Be(8);
        }

        [Fact]
        public void shouldreturnfivepercentdiscountfortwodifferentbooks()
        {
            // arrange
            var author = new Author("Roald Dahl");

            var books = new List<Book>
            {
                new Book("matilda", author, 8),
                new Book("the bfg", author, 8)
            };

            var subject = new ShoppingBasket(books,
                _roaldDahlbookSort,
                _nonRoaldDahlBookSort,
                _roaldDahlPriceGenerator,
                _nonRoaldDahlPriceGenerator);

            // act
            var result = subject.CalculateShoppingBasketTotal();

            // assert
            result.Should().Be(15.20);
        }

        [Fact]
        public void ShouldReturnTenPercentDiscountForThreeDifferentBooks()
        {
            // Arrange
            var author = new Author("Roald Dahl");

            var books = new List<Book>
            {
                new Book("Matilda", author, 8),
                new Book("The BFG", author, 8),
                new Book("The Witches", author, 8)
            };

            var subject = new ShoppingBasket(books,
                _roaldDahlbookSort,
                _nonRoaldDahlBookSort,
                _roaldDahlPriceGenerator,
                _nonRoaldDahlPriceGenerator);

            // Act
            var result = subject.CalculateShoppingBasketTotal();

            // Assert
            result.Should().Be(21.60);
        }

        [Fact]
        public void ShouldReturnTwentyPercentDiscountForFourDifferentBooks()
        {
            // Arrange
            var author = new Author("Roald Dahl");

            var books = new List<Book>
            {
                new Book("Matilda", author, 8),
                new Book("The BFG", author, 8),
                new Book("The Witches", author, 8),
                new Book("Boy", author, 8)
            };

            var subject = new ShoppingBasket(books,
                 _roaldDahlbookSort,
                 _nonRoaldDahlBookSort,
                 _roaldDahlPriceGenerator,
                 _nonRoaldDahlPriceGenerator);

            // Act
            var result = subject.CalculateShoppingBasketTotal();

            // Assert
            result.Should().Be(25.60);
        }

        [Fact]
        public void ShouldReturnTwentyFivePercentDiscountForFiveDifferentBooks()
        {
            // Arrange
            var author = new Author("Roald Dahl");

            var books = new List<Book>
            {
                new Book("Matilda", author, 8),
                new Book("The BFG", author, 8),
                new Book("The Witches", author, 8),
                new Book("Boy", author, 8),
                new Book("James & The Giant Peach", author, 8)
            };

            var subject = new ShoppingBasket(books,
                _roaldDahlbookSort,
                _nonRoaldDahlBookSort,
                _roaldDahlPriceGenerator,
                _nonRoaldDahlPriceGenerator);

            // Act
            var result = subject.CalculateShoppingBasketTotal();

        // Assert
        result.Should().Be(30.00);
    }

    [Fact]
    public void ShouldCalculateCorrectPriceForThreeRoaldDahlBooksAndOneBookFromAnotherAuthor()
    {
        // Arrange
        var author = new Author("Roald Dahl");
        var secondAuthor = new Author("Linton Mackereth");


        var books = new List<Book>
            {
                new Book("Matilda", author, 8),
                new Book("The BFG", author, 8),
                new Book("The Witches", author, 8),
                new Book("Learning To Code", secondAuthor, 8)
            };

        var numberOfRoaldDahlBooks = new List<int> { 3 };
        var numberOfNonRoaldDahlBooks = 1;


        var subject = new ShoppingBasket(books,
                _roaldDahlbookSort,
                _nonRoaldDahlBookSort,
                _roaldDahlPriceGenerator,
                _nonRoaldDahlPriceGenerator);


        // Act
        var result = subject.CalculateShoppingBasketTotal();

        // Assert
        result.Should().Be(29.60);
    }
}
}

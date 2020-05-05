using DahlKata.Core.Models;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DahlKata.Test.Models
{
    public class BookTests
    {
        [Fact]
        public void ShouldCreateAnAuthor()
        {
            // Arrange
            var author = new Author("Roald Dahl");
            var book = new Book("The Witches", author, 8);


            // Assert
            book.Author.Name.Should().Be("Roald Dahl");
            book.Title.Should().Be("The Witches");
            book.Price.Should().Be(8);


        }
    }
}

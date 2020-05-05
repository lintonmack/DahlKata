using DahlKata.Core.Models;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DahlKata.Test.Models
{
    public class AuthorTest
    {
        [Fact]
        public void ShouldCreateAnAuthor()
        {
            // Arrange
            var author = new Author("Roald Dahl");


            // Assert
            author.Name.Should().Be("Roald Dahl");

        }
    }
}

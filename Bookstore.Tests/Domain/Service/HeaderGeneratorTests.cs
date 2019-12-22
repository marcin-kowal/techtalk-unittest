using System;
using System.Collections.Generic;
using Bookstore.DataAccess.Model;
using Bookstore.Domain.Service;
using FluentAssertions;
using Xunit;

namespace Bookstore.Tests.Domain.Service
{
    public class HeaderGeneratorTests
    {
        [Theory]
        [MemberData(nameof(GenerateData))]
        public void GenerateTest(
            BookModel book,
            string expected)
        {
            // Arrange
            var generator = new HeaderGenerator(new StringHelper());

            // Act
            var actual = generator.Generate(book);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        public static IEnumerable<object[]> GenerateData()
        {
            var joNesboPoliceBook = new BookModel()
            {
                Title = "police",
                ReleaseDate = new DateTime(2013, 10, 1),
                Author = new AuthorModel()
                {
                    FirstName = "jo",
                    LastName = "nesbo"
                }
            };

            var agathaChristieEndlessNightBook = new BookModel()
            {
                Title = "endless night",
                ReleaseDate = new DateTime(1967, 10, 30),
                Author = new AuthorModel()
                {
                    FirstName = "agatha",
                    LastName = "christie"
                }
            };

            yield return new object[] { joNesboPoliceBook, "Police - Jo Nesbo - 2013" };
            yield return new object[] { agathaChristieEndlessNightBook, "Endless Night - Agatha Christie - 1967" };
        }
    }
}
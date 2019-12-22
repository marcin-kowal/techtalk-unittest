using System;
using Bookstore.Application.Mapper;
using Bookstore.Application.Model;
using Bookstore.DataAccess.Model;

namespace Bookstore.ConsoleTests.Application.Mapper
{
    public class BookDtoMapperTests
    {
        public void Map_Always_AllPropertiesMapped()
        {
            // Arrange
            var mapper = new BookDtoMapper();

            var authorModel = new AuthorModel()
            {
                Id = 234,
                BirthDate = new DateTime(1967, 3, 2),
                FirstName = "John",
                LastName = "Doe"
            };

            var bookModel = new BookModel()
            {
                Id = 123,
                Title = "My book",
                ReleaseDate = new DateTime(2017, 8, 9),
                Author = authorModel
            };

            var expected = new BookDto()
            {
                Id = bookModel.Id,
                Title = bookModel.Title,
                ReleaseDate = bookModel.ReleaseDate,
                AuthorName = authorModel.FirstName + " - " + authorModel.LastName
            };

            // Act
            var actual = mapper.Map(bookModel);

            // Assert
            try
            {
                CheckIfEqual(nameof(BookDto.Id), actual.Id, expected.Id);
                CheckIfEqual(nameof(BookDto.Title), actual.Title, expected.Title);
                CheckIfEqual(nameof(BookDto.ReleaseDate), actual.ReleaseDate, expected.ReleaseDate);
                CheckIfEqual(nameof(BookDto.AuthorName), actual.AuthorName, expected.AuthorName);

                Console.WriteLine($"{nameof(Map_Always_AllPropertiesMapped)} - test passed");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{nameof(Map_Always_AllPropertiesMapped)} - test failed: {ex.Message}");
            }
        }

        public void CheckIfEqual<T>(
            string propertyName,
            T actual,
            T expected)
        {
            if (actual.Equals(expected) == false)
            {
                throw new Exception($"{propertyName} - actual value was: '{actual}' while expected was: '{expected}'.");
            }
        }
    }
}
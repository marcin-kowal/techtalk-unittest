using AutoFixture;
using Bookstore.Application.Mapper;
using Bookstore.Application.Model;
using Bookstore.DataAccess.Model;
using Xunit;

namespace Bookstore.Tests.Application.Mapper
{
    public class BookDtoMapperTests
    {
        [Fact]
        public void Map_Always_AllPropertiesMapped()
        {
            // Arrange
            var mapper = new BookDtoMapper();

            var fixture = new Fixture();
            var bookModel = fixture.Create<BookModel>();

            var expected = new BookDto()
            {
                Id = bookModel.Id,
                Title = bookModel.Title,
                ReleaseDate = bookModel.ReleaseDate,
                AuthorName = bookModel.Author.FirstName + " " + bookModel.Author.LastName
            };

            // Act
            var actual = mapper.Map(bookModel);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}

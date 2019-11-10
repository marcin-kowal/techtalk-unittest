using Bookstore.Application.Model;
using Bookstore.DataAccess.Model;

namespace Bookstore.Application.Mapper
{
    public class BookDtoMapper
    {
        public BookDto Map(BookModel model)
        {
            return new BookDto()
            {
                Id = model.Id,
                Title = model.Title,
                ReleaseDate = model.ReleaseDate,
                AuthorName = $"{model.Author.FirstName} {model.Author.LastName}"
            };
        }
    }
}
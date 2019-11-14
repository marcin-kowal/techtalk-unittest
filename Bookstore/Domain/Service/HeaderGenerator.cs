using Bookstore.DataAccess.Model;

namespace Bookstore.Domain.Service
{
    public class HeaderGenerator
    {
        private readonly IStringHelper _stringHelper;

        public HeaderGenerator(IStringHelper stringHelper)
        {
            _stringHelper = stringHelper;
        }

        public string Generate(BookModel book)
        {
            return _stringHelper.MakeFirstLetterCapital(book.Title)
                + " - "
                + _stringHelper.MakeFirstLetterCapitalAndRestLower(book.Author.FirstName)
                + " "
                + _stringHelper.MakeFirstLetterCapitalAndRestLower(book.Author.LastName)
                + " - "
                + book.ReleaseDate.ToString("yyyy");
        }
    }
}
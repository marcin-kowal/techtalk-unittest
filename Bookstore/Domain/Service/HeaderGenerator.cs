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
                + _stringHelper.MakeFirstLetterCapitalAndLowerOthers(book.Author.FirstName)
                + " "
                + _stringHelper.MakeFirstLetterCapitalAndLowerOthers(book.Author.LastName)
                + " - "
                + book.ReleaseDate.ToString("yyyy");
        }

        /*public string Generate(BookModel book)
        {
            var title = _stringHelper.MakeFirstLetterCapital(book.Title);
            var author = $"{_stringHelper.MakeFirstLetterCapitalAndRestLower(book.Author.FirstName)} {_stringHelper.MakeFirstLetterCapitalAndRestLower(book.Author.LastName)}";
            var releaseYear = book.ReleaseDate.ToString("yyyy");

            return $"{title} - {author} - {releaseYear}";
        }*/

// change of requirements !!!

        /*public string Generate(BookModel book)
        {
            string title = GenerateTitle(book);
            var author = $"{_stringHelper.MakeFirstLetterCapitalAndRestLower(book.Author.FirstName)} {_stringHelper.MakeFirstLetterCapitalAndRestLower(book.Author.LastName)}";
            var releaseYear = book.ReleaseDate.ToString("yyyy");

            return $"{title} - {author} - {releaseYear}";
        }

        private string GenerateTitle(BookModel book)
        {
            var title = _stringHelper.MakeFirstLetterCapital(book.Title);

            if (title.Length > 10)
            {
                title = $"{title.Substring(0, 7)}...";
            }

            return title;
        }*/
    }
}
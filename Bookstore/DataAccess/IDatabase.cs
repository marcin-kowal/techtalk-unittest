using Bookstore.DataAccess.Model;

namespace Bookstore.DataAccess
{
    public interface IDatabase
    {
        BookModel[] GetBooks(string where);

        void SaveBooks(BookModel[] bookModels);
    }
}
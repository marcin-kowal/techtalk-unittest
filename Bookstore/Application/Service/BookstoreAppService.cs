using System;
using Bookstore.DataAccess;

namespace Bookstore.Application.Service
{
    public class BookstoreAppService
    {
        private readonly IDatabase _database = null;

        public void RecalculatePrices()
        {
            var today = DateTime.Today;

            var books = _database.GetBooks("Price > 10");

            foreach (var book in books)
            {
                // discount for old books
                if (today - book.ReleaseDate > TimeSpan.FromDays(365))
                {
                    book.Price *= 0.9m;
                }

                // new tax included
                if (book.Price > 100)
                {
                    book.Price += 5;
                }
            }

            _database.SaveBooks(books);
        }
    }
}
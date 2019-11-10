using System;

namespace Bookstore.Application.Model
{
    public class BookDto
    {
        public int Id { get; set; }
        public string Title {get;set;}
        public DateTime ReleaseDate { get; set; }

        public string AuthorName { get; set; }
    }
}
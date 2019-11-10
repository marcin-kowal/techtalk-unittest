﻿using System;

namespace Bookstore.DataAccess.Model
{
    public class BookModel
    {
        public int Id { get; set; }
        public string Title {get;set;}
        public DateTime ReleaseDate { get; set; }

        public AuthorModel Author { get; set; }
    }
}
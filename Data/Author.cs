﻿using my_books.Data.Models;
using System.Collections.Generic;

namespace my_books.Data
{
    public class Author
    {
        public int Id { get; set; }
        public string FullName { get; set; }

        //Navigation Properties
         public List<Book_Author> Book_Authors { get; set; }
    }
}

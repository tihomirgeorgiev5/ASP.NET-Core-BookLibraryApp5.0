﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibraryApp5._0.Models.Books
{
    public class BookListingViewModel
    {
        public int Id { get; init; }
        public string Title { get; init; }

        public string Author { get; init; }

        public string Publisher { get; init; }

        public string ImageUrl { get; init; }

        public int Year { get; init; }

        public string Category { get; init; }
    }
}

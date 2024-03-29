﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookLibraryApp5._0.Data.Models
{
    public class Category
    {
        public Category()
        {

            this.Books = new List<Book>();
        }

        public int Id { get; init; }

        [Required]

        public string Name { get; set; }

        public IEnumerable<Book> Books { get; init; }
    }
}

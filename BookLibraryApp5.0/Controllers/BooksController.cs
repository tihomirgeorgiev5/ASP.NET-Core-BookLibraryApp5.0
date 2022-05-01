using BookLibraryApp5._0.Data;
using BookLibraryApp5._0.Data.Models;
using BookLibraryApp5._0.Models.Books;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace BookLibraryApp5._0.Controllers
{
    public class BooksController : Controller
    {
        private readonly BookLibraryDbContext data;

        public BooksController(BookLibraryDbContext data)
        {
            this.data = data;
        }
        public IActionResult Add() => View(new AddBookFormModel
        {
            Categories = this.GetBookCategories()
        });

        [HttpPost]
        public IActionResult Add(AddBookFormModel book)
        {

            var bookModel = new Book()
            {
                Title = book.Title,
                Author = book.Author,
                CategoryId = book.CategoryId,
                Description = book.Description,
                ImageUrl = book.ImageUrl,
                Publisher = book.Publisher,
                Year = book.Year

            };

            this.data.Books.Add(bookModel);
            this.data.SaveChanges();

            return View();
        }

        private IEnumerable<BookCategoryViewModel> GetBookCategories()
            => this.data
            .Categories
            .Select(c => new BookCategoryViewModel
            {
                Id = c.Id,
                Name = c.Name
            })
            .ToList();
            
        


    }
}
 
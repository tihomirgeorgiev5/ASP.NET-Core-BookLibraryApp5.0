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

        public IActionResult All()
        {
            var books = this.data
                .Books
                .OrderByDescending(b => b.Id)
                .Select(b => new BookListingViewModel
                {
                    Id = b.Id,
                    Title = b.Title,
                    Author = b.Author,
                    Publisher = b.Publisher,
                    Year = b.Year,
                    ImageUrl = b.ImageUrl,
                    Category = b.Category.Name
                })
                .ToList();

            return View(books);

        }

        [HttpPost]
        public IActionResult Add(AddBookFormModel book)
        {
            if (!this.data.Categories.Any(c => c.Id == book.CategoryId))
            {
                this.ModelState.AddModelError(nameof(book.CategoryId), "Category doe not exist.");
            }

            if (!ModelState.IsValid)
            {
                book.Categories = this.GetBookCategories();
                return View(book);
            }

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

            return RedirectToAction("Index", "Home");
           
           

           
        }

        private IEnumerable<BookCategoryViewModel> GetBookCategories()
            => this.data
            .Categories
            .Select(b => new BookCategoryViewModel
            {
                Id = b.Id,
                Name = b.Name
            })
            .ToList();
            
        


    }
}
 
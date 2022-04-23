using BookLibraryApp5._0.Models.Books;
using Microsoft.AspNetCore.Mvc;

namespace BookLibraryApp5._0.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Add() => View();

        [HttpPost]
        public IActionResult Add(AddBookFormModel book)
        {
            return View();
        }
    }
}

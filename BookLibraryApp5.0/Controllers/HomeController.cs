using BookLibraryApp5._0.Data;
using BookLibraryApp5._0.Models;
using BookLibraryApp5._0.Models.Books;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Linq;

namespace BookLibraryApp5._0.Controllers
{
    public class HomeController : Controller
    {
        private readonly BookLibraryDbContext data;

        public HomeController(BookLibraryDbContext data)
            => this.data = data;

        public IActionResult Index()
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
               .Take(3)
               .ToList();

            return View(books);
        }
          
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() => View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        
    }
}

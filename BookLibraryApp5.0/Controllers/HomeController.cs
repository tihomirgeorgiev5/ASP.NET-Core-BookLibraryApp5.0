using BookLibraryApp5._0.Data;
using BookLibraryApp5._0.Models;
using BookLibraryApp5._0.Models.Home;
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
            var totalBooks = this.data.Books.Count();
            var books = this.data
               .Books
               .OrderByDescending(b => b.Id)
               .Select(b => new BookIndexViewModel
               {
                   Id = b.Id,
                   Title = b.Title,
                   Author = b.Author,
                   Publisher = b.Publisher,
                   Year = b.Year,
                   ImageUrl = b.ImageUrl,
                  
               })
               .Take(3)
               .ToList();

            return View(new IndexViewModel
            { 
                 TotalBooks = totalBooks,
                 Books = books
            });
        }
          
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() => View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        
    }
}

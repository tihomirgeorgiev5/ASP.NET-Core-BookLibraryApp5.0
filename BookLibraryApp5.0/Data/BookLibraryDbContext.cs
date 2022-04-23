using BookLibraryApp5._0.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace BookLibraryApp5._0.Data
{
    public class BookLibraryDbContext : IdentityDbContext
    {
       
        public BookLibraryDbContext(DbContextOptions<BookLibraryDbContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; init; }

        public DbSet<Category> Categories { get; init; }
    }
}

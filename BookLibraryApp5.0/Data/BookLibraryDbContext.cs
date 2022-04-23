using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using static BookLibraryApp5._0.Data.DataConstants;

namespace BookLibraryApp5._0.Data
{
    public class BookLibraryDbContext : IdentityDbContext
    {
        public DbSet<Book> Books { get; init; }
        public BookLibraryDbContext(DbContextOptions<BookLibraryDbContext> options)
            : base(options)
        {
        }
    }
}

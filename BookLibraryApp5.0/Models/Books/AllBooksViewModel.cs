using System.Collections.Generic;

namespace BookLibraryApp5._0.Models.Books
{
    public class AllBooksQueryModel
    {
        public IEnumerable<string> Titel { get; init; }
        public IEnumerable<string> SearchTerm { get; init; }
        public BookSorting Sorting { get; init; }
        public IEnumerable<BookListingViewModel> Books { get; init; }

    }
}
 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookLibraryApp5._0.Models.Books
{
    public class AllBooksQueryModel
    {
        public IEnumerable<string> Title { get; init; }

        [Display(Name = "Search by text:")]
        public string SearchTerm { get; init; }
        public BookSorting Sorting { get; init; }
        public IEnumerable<BookListingViewModel> Books { get; init; }

    }
}
 
using System.Collections.Generic;

namespace BookLibraryApp5._0.Models.Home
{
    public class IndexViewModel
    {
        public int TotalBooks { get; init; }
        public int TotalUsers { get; init; }
        public int TotalRents { get; init; }

        public List<BookIndexViewModel> Books { get; init; }
    }
}

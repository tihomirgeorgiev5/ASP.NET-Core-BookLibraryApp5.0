using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookLibraryApp5._0.Models.Books
{
    public class AddBookFormModel
    {       
        public string Title { get; init; }
        
        public string Author { get; init; }

        public string Publisher { get; init; }

        [Display(Name = "Image URL")]
       
        public string ImageUrl { get; init; }
    
        public string Description { get; init; }

        public int Year { get; init; }

        [Display(Name = "Category")]

        public int CategoryId { get; init; }

        public IEnumerable<BookCategoryViewModel> Categories { get; set; }
    }
}

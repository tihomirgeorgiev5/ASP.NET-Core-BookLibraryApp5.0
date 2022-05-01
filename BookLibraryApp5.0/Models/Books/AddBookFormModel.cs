using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using static BookLibraryApp5._0.Data.DataConstants.Book;

namespace BookLibraryApp5._0.Models.Books
{
    public class AddBookFormModel
    {
        [Required]
        [StringLength(BookTitleMaxLength, MinimumLength = BookTitleMinLength)]
        public string Title { get; init; }

        [Required]
       [StringLength(BookAuthorMaxLength, MinimumLength = BookAuthorMinLength)]
        public string Author { get; init; }

        [Required]
        [StringLength(BookPublisherMaxLength, MinimumLength = BookPublisherMinLength)] 
        public string Publisher { get; init; }

        [Required]
        [Display(Name = "Image URL")]
        [Url]
        public string ImageUrl { get; init; }

        [Required]
       [StringLength(BookPublisherMaxLength, MinimumLength = BookPublisherMinLength)]
        public string Description { get; init; }

        [Range(BookYearMinValue, BookYearMaxValue)]
        public int Year { get; init; }

        [Display(Name = "Category")]
        public int CategoryId { get; init; }

        public IEnumerable<BookCategoryViewModel> Categories { get; set; }
    }
}

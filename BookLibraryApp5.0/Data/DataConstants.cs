namespace BookLibraryApp5._0.Data
{
    public class DataConstants
    {
        public class Book
        {
            public const int IdMaxLength = 40;
            public const int BookTitleMaxLength = 50;
            public const int BookTitleMinLength = 2;
            public const int BookAuthorMaxLength = 60;
            public const int BookAuthorMinLength = 2;
            
            public const int BookDescriptionMinLength = 10;
            public const int BookDescriptionMaxLength = 10000;
            
            public const int BookPublisherMaxLength = 40;
            public const int BookPublisherMinLength = 2;
            public const int BookYearMinValue = 500;
            public const int BookYearMaxValue = 2050;


        }
    }
}

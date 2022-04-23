using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibraryApp5._0.Data
{
    public class DataConstants
    {
        public class Book
        {
            public const int IdMaxLength = 40;

            public const int BookTitleMinLength = 1;
            public const int BookTitleMaxLength = 50;


            public const int BookDescriptionMinLength = 5;

            public const int BookAuthorMinLength = 2;
            public const int BookAuthorMaxLength = 40;

            public const int BookPublisherMinLength = 2;
            public const int BookPublisherMaxLength = 30;

            public const int BookYearMinValue = 1000;
            public const int BookYearMaxValue = 2100;
        }
    }
}

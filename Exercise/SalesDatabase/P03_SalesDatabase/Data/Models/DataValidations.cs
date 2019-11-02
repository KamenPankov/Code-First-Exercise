using System;
using System.Collections.Generic;
using System.Text;

namespace P03_SalesDatabase.Data.Models
{
    public static class DataValidations
    {
        public static class Product
        {
            public const int MaxNameLength = 50;

            public const int MaxDescriptionLength = 250;
        }

        public static class Customer
        {
            public const int MaxNameLength = 100;

            public const string EmailTypeLength = "varchar(80)";
        }

        public static class Store
        {
            public const int MaxNameLength = 80;
        }
    }
}

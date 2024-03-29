﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace P03_SalesDatabase.Data.Models
{
    public class Sale
    {
        [Key]
        public int SaleId { get; set; }

        public DateTime Date { get; set; }

        public int ProductId { get; set; }

        public int CustomerId { get; set; }

        public int StoreId { get; set; }

        public Product Product { get; set; }

        public Customer Customer { get; set; }

        public Store Store { get; set; }


    }
}

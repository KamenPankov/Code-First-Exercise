using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace P03_SalesDatabase.Data.Models
{
    public class Product
    {
        public Product()
        {
            this.Sales = new HashSet<Sale>();
        }

        [Key]
        public int ProductId { get; set; }

        [Required]
        [MaxLength(DataValidations.Product.MaxNameLength)]
        public string Name { get; set; }

        [Required]
        public double Quantity { get; set; }

        [Required]
        public decimal Price { get; set; }

        [MaxLength(DataValidations.Product.MaxDescriptionLength)]
        public string Description { get; set; }

        public ICollection<Sale> Sales { get; set; }
    }
}

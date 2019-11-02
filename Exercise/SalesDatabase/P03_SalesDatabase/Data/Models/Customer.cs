using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace P03_SalesDatabase.Data.Models
{
    public class Customer
    {
        public Customer()
        {
            this.Sales = new HashSet<Sale>();
        }

        [Key]
        public int CustomerId { get; set; }

        [Required]
        [MaxLength(DataValidations.Customer.MaxNameLength)]
        public string Name { get; set; }

        [Column(TypeName = DataValidations.Customer.EmailTypeLength)]
        public string Email { get; set; }

        [Required]
        public string CreditCardNumber { get; set; }

        public ICollection<Sale> Sales { get; set; }
    }
}

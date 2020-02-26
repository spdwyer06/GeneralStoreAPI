using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GeneralStoreAPI.Models
{
    public class Transaction
    {
        [Key]
        public int ID { get; set; }
        
        // Foreign Keys => Customer ID & Product ID

        [ForeignKey(nameof(Customer))]
        public int CustomerID { get; set; }
        public virtual Customer Customer { get; set; }
        // creating the Customer table

        [ForeignKey(nameof(Product))]
        public int ProductID { get; set; }
        public virtual Product Product { get; set; }
        // creating the Product table

        [Required]
        public DateTime DateOfTransaction { get; set; }

        [Required]
        public decimal TransactionAmount => Product.Price * QuantitySold;
        /*
        public decimal TransactionAmount
        {
            get
            {
                return Product.Price * QuantitySold;
            }
        }
        */

        [Required]
        public int QuantitySold { get; set; }
    }
}
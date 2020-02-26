﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GeneralStoreAPI.Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Required]
        public string Brand { get; set; }
        
        [Required]
        [Range(0, int.MaxValue)]
        public int QuantityInStock { get; set; }
    }
}
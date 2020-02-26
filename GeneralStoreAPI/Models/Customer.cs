using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GeneralStoreAPI.Models
{
    public class Customer
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        // Expression body property
        public string FullName => $"{FirstName} {LastName}";
        // ReadOnly Property (only has a get) => doesn't need to be stored in the database table
        /*
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
        */

        public string Address { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
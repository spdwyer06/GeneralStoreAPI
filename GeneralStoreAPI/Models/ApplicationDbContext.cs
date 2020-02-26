using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GeneralStoreAPI.Models
{
    // Standard is to have only 1 Db Context for all your models to talk to
    public class ApplicationDbContext : DbContext
    {
        // Creating an empty ApplictionDbContext Constructor inheriting from DbContext("DefaultConnection")
        public ApplicationDbContext() : base("DefaultConnection") { }

        // DbSet & DbContext come with Entity Framework
        // refers to the table we're building out
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
    }
}
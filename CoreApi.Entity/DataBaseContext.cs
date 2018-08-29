using System;
using CoreApi.Entity.Model;
using Microsoft.EntityFrameworkCore;

namespace CoreApi.Entity
{
    public class DatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MyDatabase;Trusted_Connection=True;");
        }

        public DbSet<Customer> Customer { get; set; }
        public DbSet<CustomerAddress> CustomerAddresse { get; set; }
        public DbSet<Order> Order { get; set; }
    }
}

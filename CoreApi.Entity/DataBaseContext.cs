using System;
using CoreApi.Entity.Model;
using Microsoft.EntityFrameworkCore;

namespace CoreApi.Entity
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customer { get; set; }
        public DbSet<CustomerAddress> CustomerAddress { get; set; }
        public DbSet<Order> Order { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Users_WebApp.Models;

namespace Users_WebApp.Data
{
    public class CustomersContext : DbContext
    {
        public CustomersContext(DbContextOptions<CustomersContext> options) : base(options)
        {
        }

        public DbSet<Customers> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.HasDefaultSchema("production");
            builder.Entity<Customers>()
                .HasData(
                 new Customers
                 {
                     Id = 1,
                     Name = "John Doe",
                     Email = "JohnDoe@Example.com",
                     PhoneNumber = "123456789",
                     FlaggedForDelete = false
                 }
                );
        }
    }
}

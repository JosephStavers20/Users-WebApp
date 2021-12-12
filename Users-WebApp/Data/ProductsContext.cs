using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Users_WebApp.Models;

namespace Users_WebApp.Data
{
    public class ProductsContext : DbContext
    {
        public ProductsContext(DbContextOptions<ProductsContext> options) : base(options)
        {
        }

        public DbSet<Products> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.HasDefaultSchema("production");
            builder.Entity<Products>()
                .HasData(
                new Products
                {
                    Id = 1,
                    ProductName = "Test Item",
                    ProductDesc = "This is a test item"
                }
                );  
        }
    }
}

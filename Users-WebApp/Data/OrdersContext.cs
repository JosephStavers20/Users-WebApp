using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Users_WebApp.Models;

namespace Users_WebApp.Data
{
    public class OrdersContext : DbContext
    {
        public OrdersContext (DbContextOptions<OrdersContext> options) : base(options)
        {
        }

        public DbSet<Orders> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.HasDefaultSchema("production");
            builder.Entity<Orders>()
                .HasData(
                 new Orders
                 {
                     OrdersID = 1,
                     CustomerID = 1,
                     ProductID = 1,
                     ProductName = "Example Item",
                     ProductDescription = "This is an example item",
                     OrderProductQuantity = 4,
                     OrderTotalPrice = 13
                 }
                );
        }
    }
}

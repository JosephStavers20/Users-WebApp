using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Users_WebApp.Models;

namespace Users_WebApp.Data
{
    public class ProductReviewContext : DbContext
    {
        public ProductReviewContext(DbContextOptions<ProductReviewContext> options) : base(options)
        {
        }

        public DbSet<ProductReview> ProductReviews { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.HasDefaultSchema("production");
            builder.Entity<ProductReview>()
                .HasData(
                 new ProductReview
                 {
                     Id = 1,
                     ProductReviewContent = "This Item very good"
                 }
                );
        }
    }
}

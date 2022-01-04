using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Users_WebApp.Models;

namespace Users_WebApp.Data
{
    public class CustomerAccountDeletionRequestContext : DbContext
    {
        public CustomerAccountDeletionRequestContext (DbContextOptions<CustomerAccountDeletionRequestContext> options) : base(options)
        {
        }

        public DbSet<CustomerAccountDeletionRequest> CustomerAccountDeletionRequest { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.HasDefaultSchema("production");
            builder.Entity<CustomerAccountDeletionRequest>()
                .HasData(
                 new CustomerAccountDeletionRequest
                 {
                     CustomerID = 1,
                     DeletionReason = "Delete it pls"
                 }
                );
        }
    }
}

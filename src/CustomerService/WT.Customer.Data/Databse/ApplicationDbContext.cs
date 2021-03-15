using Microsoft.EntityFrameworkCore;
using WT.Ecommerce.Domain.Models;

namespace WT.Customer.Data.Databse
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {}

        public DbSet<CustomerInformation> CustomerInformation { get; set; }
        public DbSet<CustomerAddress> CustomerAddresses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);

            modelBuilder.Entity<CustomerInformation>().HasQueryFilter(x => !x.IsDeleted);
            modelBuilder.Entity<CustomerAddress>().HasQueryFilter(x => !x.IsDeleted);
        }

    }
}

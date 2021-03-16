using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WT.Ecommerce.Domain.Models;

namespace WT.Customer.Data.Databse.Configurations
{
    public class CustomerInformationConfiguration : IEntityTypeConfiguration<CustomerInformation>
    {
        public void Configure(EntityTypeBuilder<CustomerInformation> builder)
        {
            builder.ToTable("CustomerInformation");

            builder.HasKey(e => e.Id);

            builder.HasMany(c => c.customerAddresses)
                   .WithOne(a => a.CustomerInformation)
                   .HasForeignKey(a => a.CustomerId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

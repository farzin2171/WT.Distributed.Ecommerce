using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WT.Ecommerce.Domain.Models;


namespace WT.Customer.Data.Databse.Configurations
{
    class CustomerAddressConfiguration: IEntityTypeConfiguration<CustomerAddress>
    {
        public void Configure(EntityTypeBuilder<CustomerAddress> builder)
        {
            builder.ToTable("CustomerAddress");

            builder.HasKey(e => e.Id);

            builder.HasOne(a => a.CustomerInformation)
                   .WithMany(c => c.customerAddresses);
        }
    }
}

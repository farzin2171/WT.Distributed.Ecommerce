using System;
using System.Linq;
using WT.Customer.Data.Databse;
using WT.Ecommerce.Domain.Models;

namespace WT.Customer.Data.Repositories
{
    public class CustomerInformationRepository:BaseRepository<CustomerInformation,Guid>,ICustomerInformationRepository
    {
        public CustomerInformationRepository(ApplicationDbContext dbContext):base(dbContext)
        {

        }

        public IQueryable<CustomerAddress> GetCustomerAddresses(Guid guid)
        {
            return _dbContext.CustomerAddresses.Where(c => c.CustomerId == guid);
        }
    }
}

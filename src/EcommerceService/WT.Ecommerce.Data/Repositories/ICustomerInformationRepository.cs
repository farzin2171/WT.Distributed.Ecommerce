using System;
using System.Linq;
using WT.Ecommerce.Domain.Infrastructure;
using WT.Ecommerce.Domain.Models;

namespace WT.Customer.Data.Repositories
{
    public interface ICustomerInformationRepository: IDatabaseRepository<CustomerInformation, Guid> 
    {
        IQueryable<CustomerAddress> GetCustomerAddresses(Guid guid);
    }
}

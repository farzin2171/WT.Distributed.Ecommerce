using System;
using System.Threading.Tasks;

namespace WT.Customer.Services.Customer
{
    public interface ICustomerInformationService
    {
        Task<Guid> CreateCustomerAsync(string name, string family, string email, string phone);
        Task<Guid> CreateAddressAsync(Guid customerId,string address,string country,string city,string postalCode);

    }
}

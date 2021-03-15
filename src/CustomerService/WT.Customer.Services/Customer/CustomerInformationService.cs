using System;
using System.Threading.Tasks;
using WT.Customer.Data.Repositories;
using WT.Ecommerce.Domain.Models;

namespace WT.Customer.Services.Customer
{
    public class CustomerInformationService : ICustomerInformationService
    {
        private readonly ICustomerInformationRepository _customerInformationRepository;

        public CustomerInformationService(ICustomerInformationRepository customerInformationRepository)
        {
            _customerInformationRepository = customerInformationRepository;
        }
        public Task<Guid> CreateAddressAsync(Guid customerId, string address, string country, string city, string postalCode)
        {
            throw new NotImplementedException();
        }

        public async Task<Guid> CreateCustomerAsync(string name, string family, string email, string phone)
        {
            var newCustomer = await _customerInformationRepository.AddAsync(new CustomerInformation
            {
                FirstName=name,
                LastName=family,
                Email=email,
                PhoneNumber=phone
            });
            return newCustomer.Id;
        }
    }
}

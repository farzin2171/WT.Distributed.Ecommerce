using System;
using System.Collections.Generic;

namespace WT.Ecommerce.Domain.Models
{
    public  sealed class CustomerInformation:BaseEntity<Guid>
    {
    
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public ICollection<CustomerAddress> customerAddresses { get; set; }
    }
}

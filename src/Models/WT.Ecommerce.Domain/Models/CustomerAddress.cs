using System;

namespace WT.Ecommerce.Domain.Models
{
    public class CustomerAddress:BaseEntity<Guid>
    {
        public string Address { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public bool IsActive { get; set; }
        public Guid CustomerId { get; set; }
        public virtual CustomerInformation CustomerInformation { get; set; }

    }
}

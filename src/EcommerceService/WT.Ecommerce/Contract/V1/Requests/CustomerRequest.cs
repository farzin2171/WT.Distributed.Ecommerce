﻿namespace WT.Customer.API.Contract.V1.Requests
{
    public class CreateCustomerRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}

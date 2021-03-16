
namespace WT.Customer.API.Contract.V1
{
    public static class ApiRoutes
    {
        private const string Root = "api";
        private const string Version = "v1";
        private const string Base = Root + "/" + Version;

        public static class CustomersApi
        {
            public const string GetAllCustomerAddress = Base + "/Customers/{CustomerId}/Address";
            public const string CreateCustomer = Base + "/Customers";
            public const string CreateAddress = Base + "/Customers/{CustomerId}/Address";


        }
    }
}

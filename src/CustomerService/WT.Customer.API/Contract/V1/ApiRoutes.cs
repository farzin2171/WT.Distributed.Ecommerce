
namespace WT.Customer.API.Contract.V1
{
    public static class ApiRoutes
    {
        private const string Root = "api";
        private const string Version = "v1";
        private const string Base = Root + "/" + Version;

        public static class SampleApi
        {
            public const string GetAll = Base + "/Samples";
            public const string Create = Base + "/Samples";

        }
    }
}

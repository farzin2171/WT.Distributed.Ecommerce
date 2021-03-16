using Swashbuckle.AspNetCore.Filters;
using WT.Customer.API.Contract.V1.Requests;

namespace WT.Customer.API.Infrastructure.SwaggerExamples.Requests
{
    public class RequestExample : IExamplesProvider<ErrorModel>
    {
        public ErrorModel GetExamples()
        {
            return new ErrorModel
            {
                FieldName = "test",
                Message = "test"
            };
        }
    }
}

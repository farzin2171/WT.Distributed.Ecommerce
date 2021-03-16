using Microsoft.AspNetCore.Builder;
using WT.Customer.API.Infrastructure.MiddleWares;

namespace WT.Customer.API.Infrastructure.Extentions
{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseCustomExceptionHandler(this IApplicationBuilder app)
        {
            return app.UseMiddleware<CustomExceptionMiddleware>();
        }
    }
}

using Microsoft.AspNetCore.Http;
using System.Linq;

namespace WT.Customer.API.Infrastructure.Extentions
{
    public static class GeneralExtentions
    {
        public static string GetUserId(this HttpContext httpContext)
        {
            if (httpContext.User == null)
            {
                return string.Empty;
            }

            return httpContext.User.Claims.SingleOrDefault(x => x.Type == "id").Value;
        }
    }
}

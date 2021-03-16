using Microsoft.AspNetCore.Http;

namespace WT.Customer.API.Infrastructure.Http
{
    public static class AbsoluteUrl
    {
        public static string FromRequest(string relativeUrl, HttpRequest request)
        {
            return relativeUrl.Replace("~/", $@"{request.Scheme}://{request.Host}{request.PathBase}/");
        }
    }
}

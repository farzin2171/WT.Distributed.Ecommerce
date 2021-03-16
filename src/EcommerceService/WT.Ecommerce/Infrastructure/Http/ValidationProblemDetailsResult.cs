using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WT.Customer.API.Infrastructure.Extentions;

namespace WT.Customer.API.Infrastructure.Http
{
    public class ValidationProblemDetailsResult : IActionResult
    {
        public async Task ExecuteResultAsync(ActionContext actionContext)
        {
            await actionContext.HttpContext.Response.WriteBadRequestResponseAsync(actionContext.ModelState);
        }
    }
}

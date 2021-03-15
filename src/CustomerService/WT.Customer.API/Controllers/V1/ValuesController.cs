using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WT.Customer.API.Contract.V1;
using WT.Customer.Services.Customer;

namespace WT.Customer.API.Controllers.V1
{
    [Consumes("application/json")]
    [Produces("application/json")]
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private ICustomerInformationService _customerInformationService;

        public ValuesController(ICustomerInformationService customerInformationService)
        {
            _customerInformationService = customerInformationService;
        }
        /// <summary>
        /// Creates new customer in the system
        /// </summary>
        /// <remarks>
        /// 
        /// Sample request:
        ///
        ///     Post /api/v1/CustomerInformations
        ///
        /// </remarks>
        /// <response code="401">The JWT is missing or incorrect.</response>  
        /// <response code="403">The authorization is missing a permission</response>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [HttpGet(ApiRoutes.SampleApi.GetAll)]
        public async Task<IActionResult> Get()
        {
            var t= await _customerInformationService.CreateCustomerAsync("farzin", "faghirnavaz", "ef@gmail.com", "34555");
            return Ok();
        }
    }
}

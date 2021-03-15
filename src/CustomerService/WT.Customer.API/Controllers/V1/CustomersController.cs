using MassTransit;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WT.Customer.API.Contract.V1;
using WT.Customer.API.Contract.V1.Requests;
using WT.Customer.Services.Customer;
using WT.Ecommerce.Domain.MessagingModels;

namespace WT.Customer.API.Controllers.V1
{
    [Consumes("application/json")]
    [Produces("application/json")]
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private ICustomerInformationService _customerInformationService;
        private readonly IPublishEndpoint _publishEndpoint;


        public CustomersController(ICustomerInformationService customerInformationService, IPublishEndpoint publishEndpoint)
        {
            _customerInformationService = customerInformationService;
            _publishEndpoint = publishEndpoint;
        }
        /// <summary>
        /// Creates new customer in the system
        /// </summary>
        /// <remarks>
        /// 
        /// Sample request:
        ///
        ///     Post /api/v1/Customers
        ///
        /// </remarks>
        /// <response code="401">The JWT is missing or incorrect.</response>  
        /// <response code="403">The authorization is missing a permission</response>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [HttpPost(ApiRoutes.CustomersApi.CreateCustomer)]
        public async Task<IActionResult> Create(CreateCustomerRequest request)
        {
            var newCustomerId = await _customerInformationService.CreateCustomerAsync(request.FirstName, request.LastName, request.Email, request.PhoneNumber);
            await _publishEndpoint.Publish<CustomerMessage>(new CustomerMessage
            {
                Id = newCustomerId
            });
            return Ok(newCustomerId);
        }
    }
}

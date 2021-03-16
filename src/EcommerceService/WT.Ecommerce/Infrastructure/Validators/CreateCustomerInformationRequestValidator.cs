using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WT.Customer.API.Contract.V1.Requests;

namespace WT.Customer.API.Infrastructure.Validators
{
    public class CreateCustomerInformationRequestValidator : AbstractValidator<CreateCustomerRequest>
    {
        public CreateCustomerInformationRequestValidator()
        {
            RuleFor(x => x.FirstName).MinimumLength(3).MaximumLength(50);
            RuleFor(x => x.LastName).MinimumLength(3).MaximumLength(50);
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email address is required")
                     .EmailAddress().WithMessage("A valid email is required");
        }
    }
}

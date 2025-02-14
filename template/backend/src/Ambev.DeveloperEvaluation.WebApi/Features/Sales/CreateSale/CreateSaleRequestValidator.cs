using Ambev.DeveloperEvaluation.Domain.Validation;
using Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale
{
 

    /// <summary>
    /// Validator for CreateUserRequest that defines validation rules for user creation.
    /// </summary>
    public class CreateSaleRequestValidator : AbstractValidator<CreateSaleRequest>
    {
        /// <summary>
        /// Initializes a new instance of the CreateSaleRequestValidator with defined validation rules.
        /// </summary>
        /// <remarks>
        /// Validation rules include:
        ///  
        /// </remarks>
        public CreateSaleRequestValidator()
        {
            RuleFor(s => s.SaleDate)
                .NotEmpty().WithMessage("Sale date is required.");

            RuleFor(s => s.CustomerId)
                .NotEmpty().WithMessage("Customer is required.");

            RuleFor(s => s.BranchId)
                .NotEmpty().WithMessage("Branch is required.");

            RuleFor(s => s.Items)
                .NotEmpty().WithMessage("Sale must have at least one item.");

            RuleFor(s => s.Items)
                .NotEmpty().WithMessage("Sale must have at least one item.")
                .ForEach(itemRule =>
                {
                    itemRule.ChildRules(item =>
                    {
                        item.RuleFor(p => p.ProductId)
                            .NotEmpty().WithMessage("Product is required.");

                        item.RuleFor(p => p.Quantity)
                            .GreaterThan(0).WithMessage("Quantity must be greater than zero.")
                            .LessThanOrEqualTo(20).WithMessage("Quantity cannot exceed 20.");                                                  
                        
                    });
                });
        }
    }
}

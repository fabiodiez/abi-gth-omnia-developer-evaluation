using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Sales.CreateSale;

/// <summary>
/// Validator for CreateSaleCommand that defines validation rules for Sale creation command.
/// </summary>
public class CreateSaleCommandValidator : AbstractValidator<CreateSaleCommand>
{
    /// <summary>
    /// Initializes a new instance of the CreateSaleCommandValidator with defined validation rules.
    /// </summary>
    /// <remarks>
    /// Validation rules include:
    /// - Email: Must be in valid format (using EmailValidator)
    /// - Salename: Required, must be between 3 and 50 characters
    /// - Password: Must meet security requirements (using PasswordValidator)
    /// - Phone: Must match international format (+X XXXXXXXXXX)
    /// - Status: Cannot be set to Unknown
    /// - Role: Cannot be set to None
    /// </remarks>
    public CreateSaleCommandValidator()
    {
        RuleFor(Sale => Sale.SaleDate)
          .NotEmpty().WithMessage("Sale date is required.");

        RuleFor(Sale => Sale.CustomerId)
          .NotEmpty().WithMessage("Customer is required.");

        RuleFor(Sale => Sale.BranchId)
          .NotEmpty().WithMessage("Branch is required.");

        RuleFor(Sale => Sale.TotalAmount)
          .GreaterThanOrEqualTo(0).WithMessage("Total amount must be greater than or equal to zero.");

        RuleFor(Sale => Sale.SaleItems)
          .NotEmpty().WithMessage("Sale must have at least one item.")
          .ForEach(itemRule => {
              itemRule.ChildRules(item => item.RuleFor(p => p.ProductId).NotEmpty()).WithMessage("Product is required.");
              itemRule.ChildRules(item => item.RuleFor(p => p.Quantity).NotEmpty()).WithMessage("Quantity must be greater than zero.");
              itemRule.ChildRules(item => item.RuleFor(p => p.Discount).InclusiveBetween(0, 1)).WithMessage("Discount must be between 0 and 1 (percentage).");
              itemRule.ChildRules(item => item.RuleFor(p => p.TotalItemAmount).GreaterThanOrEqualTo(0)).WithMessage("Total item amount must be greater than or equal to zero.");
          });
    }
}
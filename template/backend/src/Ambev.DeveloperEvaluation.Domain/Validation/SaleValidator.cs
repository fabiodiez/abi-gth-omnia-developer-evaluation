using Ambev.DeveloperEvaluation.Domain.Entities;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.Domain.Validation;

/// <summary>
/// Validator for the Product entity.
/// </summary>
public class SaleValidator : AbstractValidator<Sale>
{
    public SaleValidator()
    {
        RuleFor(s => s.SaleNumber)
          .NotEmpty().WithMessage("Sale number is required.");

        RuleFor(s => s.SaleDate)
          .NotEmpty().WithMessage("Sale date is required.");

        RuleFor(s => s.CustomerId)
          .NotEmpty().WithMessage("Customer is required.");

        RuleFor(s => s.BranchId)
          .NotEmpty().WithMessage("Branch is required.");

        RuleFor(s => s.TotalAmount)
          .GreaterThanOrEqualTo(0).WithMessage("Total amount must be greater than or equal to zero.");

        RuleFor(s => s.SaleItems)
          .NotEmpty().WithMessage("Sale must have at least one item.")
          .ForEach(itemRule => {
              itemRule.ChildRules(item => item.RuleFor(p => p.ProductId).NotEmpty()).WithMessage("Product is required.");
              itemRule.ChildRules(item => item.RuleFor(p => p.Quantity).NotEmpty()).WithMessage("Quantity must be greater than zero.");
              itemRule.ChildRules(item => item.RuleFor(p => p.Discount).InclusiveBetween(0, 1)).WithMessage("Discount must be between 0 and 1 (percentage).");
              itemRule.ChildRules(item => item.RuleFor(p => p.TotalItemAmount).GreaterThanOrEqualTo(0)).WithMessage("Total item amount must be greater than or equal to zero.");
          });

    }
}
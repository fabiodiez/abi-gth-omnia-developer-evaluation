using Ambev.DeveloperEvaluation.Domain.Entities;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.Domain.Validation;

/// <summary>
/// Validator for the SaleItem entity.
/// </summary>
public class SaleItemValidator : AbstractValidator<SaleItem>
{
    public SaleItemValidator()
    {
        RuleFor(item => item.Quantity)
            .GreaterThan(0).WithMessage("Quantity must be greater than zero.")
            .LessThanOrEqualTo(20).WithMessage("Quantity cannot exceed 20 items per product.");

        RuleFor(item => item.UnitPrice)
            .GreaterThan(0).WithMessage("Unit price must be greater than zero.");

        RuleFor(item => item.Discount)
            .GreaterThanOrEqualTo(0).WithMessage("Discount cannot be negative.")
            .LessThanOrEqualTo(item => item.UnitPrice * item.Quantity)
            .WithMessage("Discount cannot exceed the total item amount.");

        RuleFor(item => item.TotalItemAmount)
            .Equal(item => (item.UnitPrice * item.Quantity) - item.Discount)
            .WithMessage("Total item amount must be correctly calculated.");
    }
}
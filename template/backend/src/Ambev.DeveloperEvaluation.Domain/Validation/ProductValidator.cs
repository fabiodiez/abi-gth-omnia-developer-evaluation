using Ambev.DeveloperEvaluation.Domain.Entities;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.Domain.Validation;

/// <summary>
/// Validator for the Product entity.
/// </summary>
public class ProductValidator : AbstractValidator<Product>
{
    public ProductValidator()
    {
        RuleFor(product => product.Name)
            .NotEmpty().WithMessage("Product name is required.")
            .MaximumLength(100).WithMessage("Product name must not exceed 100 characters.");

        RuleFor(product => product.Description)
            .MaximumLength(255).WithMessage("Product description must not exceed 255 characters.");

        RuleFor(product => product.Price)
            .GreaterThan(0).WithMessage("Product price must be greater than zero.");
    }
}
using Ambev.DeveloperEvaluation.Domain.Enums;
using Ambev.DeveloperEvaluation.Domain.Validation;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Products.CreateProduct;

/// <summary>
/// Validator for CreateProductCommand that defines validation rules for Product creation command.
/// </summary>
public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
{
    /// <summary>
    /// Initializes a new instance of the CreateProductCommandValidator with defined validation rules.
    /// </summary>
    /// <remarks>
    /// Validation rules include:
    /// - Name: Required, Product name must not exceed 100 characters.
    /// - Description: Product description must not exceed 255 characters.
    /// - Price: Product price must be greater than zero

    /// </remarks>
    public CreateProductCommandValidator()
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
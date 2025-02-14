using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Products.UpdateProduct;

/// <summary>
/// Validator for UpdateProductCommand.
/// </summary>
public class UpdateProductCommandValidator : AbstractValidator<UpdateProductCommand>
{
    public UpdateProductCommandValidator()
    {
        RuleFor(product => product.Id).NotEmpty().WithMessage("Product ID is required.");
        RuleFor(product => product.Name).NotEmpty().MaximumLength(100).WithMessage("Product name is required.")
                                       .MaximumLength(100).WithMessage("Product name must not exceed 100 characters.");
        RuleFor(product => product.Description).MaximumLength(255).WithMessage("Product description must not exceed 255 characters.");
        RuleFor(product => product.Price).GreaterThan(0).WithMessage("Product price must be greater than zero.");
    }
}
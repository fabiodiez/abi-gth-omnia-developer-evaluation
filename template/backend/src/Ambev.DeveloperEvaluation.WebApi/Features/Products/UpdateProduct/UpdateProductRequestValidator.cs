using FluentValidation;
using Ambev.DeveloperEvaluation.WebApi.Features.Products.UpdateProduct;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.UpdateProduct;

/// <summary>
/// Validator for UpdateProductRequest.
/// </summary>
public class UpdateProductRequestValidator : AbstractValidator<UpdateProductRequest>
{
    /// <summary>
    /// Initializes a new instance of the UpdateProductRequestValidator with defined validation rules.
    /// </summary>
    /// <remarks>
    /// Validation rules include:
    /// - Id: Required.
    /// - Name: Required, maximum length of 100 characters
    /// - Description: Product description must not exceed 255 characters.
    /// - Price: Product price must be greater than zero.
    /// </remarks>
    public UpdateProductRequestValidator()
    {
        RuleFor(request => request.Id).NotEmpty().WithMessage("Product ID is required.");
        RuleFor(request => request.Name).NotEmpty().WithMessage("Product name is required.")
                                       .MaximumLength(100).WithMessage("Product name must not exceed 100 characters.");
        RuleFor(request => request.Description).MaximumLength(255).WithMessage("Product description must not exceed 255 characters.");
        RuleFor(request => request.Price).GreaterThan(0).WithMessage("Product price must be greater than zero.");
    }
}
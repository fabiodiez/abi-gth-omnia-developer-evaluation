using Ambev.DeveloperEvaluation.Domain.Validation;
using Ambev.DeveloperEvaluation.WebApi.Features.Branches.CreateBranch;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.CreateProduct
{

    /// <summary>
    /// Validator for CreateProductRequestValidator that defines validation rules for user creation.
    /// </summary>
    public class CreateProductRequestValidator : AbstractValidator<CreateProductRequest>
    {
        /// <summary>
        /// Initializes a new instance of the CreateProductRequestValidator with defined validation rules.
        /// </summary>
        /// <remarks>
        /// Validation rules include:
        /// - Name: Required, maximum length of 100 characters
        /// - Description: Product description must not exceed 255 characters.
        /// - Price: Product price must be greater than zero.
        /// </remarks>
        public CreateProductRequestValidator()
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
    
}


using FluentValidation;
using Ambev.DeveloperEvaluation.WebApi.Features.Sales.UpdateSale;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.UpdateSale;

/// <summary>
/// Validator for UpdateSaleRequest.
/// </summary>
public class UpdateSaleRequestValidator : AbstractValidator<UpdateSaleRequest>
{

    /// <summary>
    /// Initializes a new instance of the UpdateSaleRequestValidator with defined validation rules.
    /// </summary>
    /// <remarks>
    /// Validation rules include:
    /// - Id: Required.
    /// - SaleNumber: Required.
    /// - SaleDate: Required.
    /// - CustomerId: Required.
    /// - BranchId: Required.
    /// - TotalAmount: Total amount must be greater than or equal to zero.
    /// </remarks>
    public UpdateSaleRequestValidator()
    {
        RuleFor(request => request.Id).NotEmpty().WithMessage("Sale ID is required.");
        RuleFor(request => request.SaleNumber).NotEmpty().WithMessage("Sale number is required.");
        RuleFor(request => request.SaleDate).NotEmpty().WithMessage("Sale date is required.");
        RuleFor(request => request.CustomerId).NotEmpty().WithMessage("Customer ID is required.");
        RuleFor(request => request.BranchId).NotEmpty().WithMessage("Branch ID is required.");
        RuleForEach(request => request.SaleItems).SetValidator(new UpdateSaleItemRequestValidator());
    }
}

/// <summary>
/// Validator for UpdateSaleItemRequest.
/// </summary>
public class UpdateSaleItemRequestValidator : AbstractValidator<UpdateSaleItemRequest>
{

    /// <summary>
    /// Initializes a new instance of the UpdateSaleItemRequestValidator with defined validation rules.
    /// </summary>
    /// <remarks>
    /// Validation rules include:
    /// - Id: Required.
    /// - ProductId: Required.
    /// - Quantity: Quantity must be greater than zero.
    /// - Name: Required, maximum length of 100 characters
    /// - UnitPrice: Unit price must be greater than zero.
    /// - Discount: Discount must be greater than or equal to zero.
    /// - TotalItemAmount: Total item amount must be greater than or equal to zero.
    /// </remarks>
    public UpdateSaleItemRequestValidator()
    {
        RuleFor(item => item.Id).NotEmpty().WithMessage("Item ID is required.");
        RuleFor(item => item.ProductId).NotEmpty().WithMessage("Product ID is required.");
        RuleFor(item => item.Quantity).GreaterThan(0).WithMessage("Quantity must be greater than zero.");
    }
}
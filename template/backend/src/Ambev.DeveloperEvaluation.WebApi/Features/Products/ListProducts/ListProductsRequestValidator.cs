using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.ListProducts;

/// <summary>
/// Validator for GetBranchRequest
/// </summary>
public class ListProductsRequestValidator : AbstractValidator<ListProductsRequest>
{
    /// <summary>
    /// Initializes validation rules for GetBranchRequest
    /// </summary>
    public ListProductsRequestValidator()
    {   
    }
}

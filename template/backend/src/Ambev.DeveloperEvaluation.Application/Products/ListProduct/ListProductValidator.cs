using Ambev.DeveloperEvaluation.Application.Products.ListProducts;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Products.GetProduct;

/// <summary>
/// Validator for ListProductsQuery
/// </summary>
public class ListProductValidator : AbstractValidator<ListProductsQuery>
{
    /// <summary>
    /// Initializes validation rules for ListProductsQuery
    /// </summary>
    public ListProductValidator()
    {
       
    }
}

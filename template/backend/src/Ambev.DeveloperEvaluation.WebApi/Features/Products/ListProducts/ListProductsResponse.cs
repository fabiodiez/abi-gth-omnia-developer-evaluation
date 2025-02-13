using Ambev.DeveloperEvaluation.Application.Products.ListProducts;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.ListProducts;

/// <summary>
/// Response for listing products.
/// </summary>
public class ListProductsResponse
{
    public IEnumerable<ProductDto> Products { get; set; } = new List<ProductDto>();
}
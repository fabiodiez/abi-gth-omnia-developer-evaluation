namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.UpdateProduct;

/// <summary>
/// Response for updating a Product.
/// </summary>
public class UpdateProductResponse
{
    public bool Success { get; set; }
    public string Message { get; set; } = string.Empty;
}
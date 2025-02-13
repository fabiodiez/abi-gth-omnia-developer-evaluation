namespace Ambev.DeveloperEvaluation.Application.Products.UpdateProduct;

/// <summary>
/// Result for updating a Product.
/// </summary>
public class UpdateProductResult
{
    public bool Success { get; set; }
    public string Message { get; set; } = string.Empty;
}
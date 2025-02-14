using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.Application.Products.GetProduct;

/// <summary>
/// Response model for GetProduct operation
/// </summary>
public class GetProductResult
{
    /// <summary>
    /// The unique identifier of the product 
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// The product's name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The product's description
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// The product's price
    /// </summary>
    public decimal Price { get; set; }
}

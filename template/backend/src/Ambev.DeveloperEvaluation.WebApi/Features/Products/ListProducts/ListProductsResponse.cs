namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.ListProducts;

/// <summary>
/// Response for listing products.
/// </summary>
public class ListProductsResponse
{
    public IEnumerable<ProductDto> Products { get; set; } = new List<ProductDto>();
}

/// <summary>
/// DTO for Product.
/// </summary>
public class ProductDto
{
    /// <summary>
    /// The unique identifier of the product 
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Gets or sets the name of the product.
    /// Must not be null or empty and should be unique within the system.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the description of the product.
    /// Provides additional details about the product.
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the price of the product.
    /// Must be a positive value and represents the unit price in the system's currency.
    /// </summary>
    public decimal Price { get; set; }

    /// <summary>
    /// Gets or sets the date and time when the product was created.
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// Gets or sets the date and time of the last update to the product's information.
    /// </summary>
    public DateTime? UpdatedAt { get; set; }
}
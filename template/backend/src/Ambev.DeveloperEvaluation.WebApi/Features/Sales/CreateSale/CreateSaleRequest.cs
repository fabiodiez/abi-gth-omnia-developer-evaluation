using System;
using System.Collections.Generic;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale;

/// <summary>
/// Represents a request to create a new sale in the system.
/// </summary>
public class CreateSaleRequest
{
    /// <summary>
    /// Gets or sets the date of the sale.
    /// </summary>
    public DateTime SaleDate { get; set; }

    /// <summary>
    /// Gets or sets the ID of the customer associated with the sale.
    /// </summary>
    public Guid CustomerId { get; set; }

    /// <summary>
    /// Gets or sets the ID of the branch where the sale was made.
    /// </summary>
    public Guid BranchId { get; set; }

    /// <summary>
    /// Gets or sets the list of items included in the sale.
    /// </summary>
    public List<SaleItemRequest> Items { get; set; } = new List<SaleItemRequest>();
}

/// <summary>
/// Represents an item included in a sale.
/// </summary>
public class SaleItemRequest
{
    /// <summary>
    /// Gets or sets the ID of the product.
    /// </summary>
    public Guid ProductId { get; set; }

    /// <summary>
    /// Gets or sets the quantity of the product.
    /// </summary>
    public int Quantity { get; set; }    

    /// <summary>
    /// Gets or sets the discount applied to the item.
    /// </summary>
    public decimal Discount { get; set; }

}
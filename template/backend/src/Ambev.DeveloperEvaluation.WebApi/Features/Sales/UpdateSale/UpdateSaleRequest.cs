namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.UpdateSale;

/// <summary>
/// Request for updating a Sale.
/// </summary>
public class UpdateSaleRequest
{
    /// <summary>
    /// The unique identifier of the sale
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// The number of the sale
    /// </summary>
    public int SaleNumber { get; set; }

    /// <summary>
    /// The sale date
    /// </summary>
    public DateTime SaleDate { get; set; }

    /// <summary>
    /// The customer's unique identifier
    /// </summary>
    public Guid CustomerId { get; set; }

    /// <summary>
    /// The total amount of the sale
    /// </summary>
    public decimal TotalAmount { get; set; }

    /// <summary>
    /// The branch's unique identifier
    /// </summary>
    public Guid BranchId { get; set; }

    /// <summary>
    /// The sale status
    /// </summary>
    public bool IsCancelled { get; set; }

    /// <summary>
    /// the list of items included in the sale
    /// </summary>
    public IEnumerable<UpdateSaleItemRequest> SaleItems { get; set; } = new List<UpdateSaleItemRequest>();
}

/// <summary>
/// Request for updating a SaleItem.
/// </summary>
public class UpdateSaleItemRequest
{
    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal Discount { get; set; }
    public decimal TotalItemAmount { get; set; }
}
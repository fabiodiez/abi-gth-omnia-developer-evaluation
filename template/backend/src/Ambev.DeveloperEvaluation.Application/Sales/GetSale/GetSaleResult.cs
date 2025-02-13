using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.Application.Sales.GetSale;

/// <summary>
/// Response model for GetSale operation
/// </summary>
public class GetSaleResult
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
    public ICollection<ISaleItem> SaleItems { get; set; }
}

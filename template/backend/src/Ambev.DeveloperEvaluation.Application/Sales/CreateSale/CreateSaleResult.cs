using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Application.Sales.CreateSale;

/// <summary>
/// Represents the response returned after successfully creating a new Sale.
/// </summary>
/// <remarks>
/// This response contains the unique identifier of the newly created Sale,
/// which can be used for subsequent operations or reference.
/// </remarks>
public class CreateSaleResult
{
    /// <summary>
    /// Gets or sets the unique identifier of the newly created Sale.
    /// </summary>
    /// <value>A GUID that uniquely identifies the created Sale in the system.</value>
    public Guid Id { get; set; }

    /// <summary>
    /// Gets or sets the unique number of the sale.
    /// Must not be null or empty.
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
    /// Gets or sets the customer associated with the sale.
    /// </summary>
    public User Customer { get; set; }

    /// <summary>
    /// Gets or sets the branch where the sale was made.
    /// </summary>
    public Branch Branch { get; set; }

    /// <summary>
    /// Gets or sets the collection of items included in the sale.
    /// </summary>
    /// 
    /// <summary>
    /// the list of items included in the sale
    /// </summary>
    public ICollection<SaleItem> SaleItems { get; set; }

}

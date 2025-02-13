namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.ListSales;

/// <summary>
/// Response for listing sales.
/// </summary>
public class ListSalesResponse
{
    public IEnumerable<SaleDto> Sales { get; set; } = new List<SaleDto>();
}

/// <summary>
/// DTO for Sale.
/// </summary>
public class SaleDto
{
    public Guid Id { get; set; }
    public int SaleNumber { get; set; }
    public DateTime SaleDate { get; set; }
    public Guid CustomerId { get; set; }
    public decimal TotalAmount { get; set; }
    public Guid BranchId { get; set; }
    public bool IsCancelled { get; set; }
    public IEnumerable<SaleItemDto> SaleItems { get; set; } = new List<SaleItemDto>();
}

/// <summary>
/// DTO for SaleItem.
/// </summary>
public class SaleItemDto
{
    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal Discount { get; set; }
    public decimal TotalItemAmount { get; set; }
}
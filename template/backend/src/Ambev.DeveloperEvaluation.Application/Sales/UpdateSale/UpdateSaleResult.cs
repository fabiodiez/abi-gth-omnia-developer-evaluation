namespace Ambev.DeveloperEvaluation.Application.Sales.UpdateSale;

/// <summary>
/// Result for updating a Sale.
/// </summary>
public class UpdateSaleResult
{
    public bool Success { get; set; }
    public string Message { get; set; } = string.Empty;
}
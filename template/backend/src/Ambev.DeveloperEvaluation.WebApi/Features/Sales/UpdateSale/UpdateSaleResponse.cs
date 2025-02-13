namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.UpdateSale;

/// <summary>
/// Response for updating a Sale.
/// </summary>
public class UpdateSaleResponse
{
    public bool Success { get; set; }
    public string Message { get; set; } = string.Empty;
}
using Ambev.DeveloperEvaluation.Application.Sales.ListSales;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.ListSales;

/// <summary>
/// Response for listing sales.
/// </summary>
public class ListSalesResponse
{
    public IEnumerable<SaleDto> Sales { get; set; } = new List<SaleDto>();
}
 
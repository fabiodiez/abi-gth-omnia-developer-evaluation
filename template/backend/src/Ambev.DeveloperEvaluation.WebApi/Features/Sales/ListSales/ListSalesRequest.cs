namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.ListSales;

/// <summary>
/// Request for listing sales.
/// </summary>
public class ListSalesRequest
{
      public string Filter { get; set; }
      public int Page { get; set; }
      public int PageSize { get; set; }
}
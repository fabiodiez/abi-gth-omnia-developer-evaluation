using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Sales.ListSales;

/// <summary>
/// Query for listing sales.
/// </summary>
/// <remarks>
/// This query is used to retrieve a list of sales from the system.
/// It implements <see cref="IRequest{TResponse}"/> to initiate the request
/// that returns a <see cref="ListSalesResult"/>.
/// </remarks>
public class ListSalesQuery : IRequest<ListSalesResult>
{
     
     public string Filter { get; set; }
     public int Page { get; set; }
     public int PageSize { get; set; }
}
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Products.ListProducts;

/// <summary>
/// Query for listing products.
/// </summary>
/// <remarks>
/// This query is used to retrieve a list of products from the system.
/// It implements <see cref="IRequest{TResponse}"/> to initiate the request
/// that returns a <see cref="ListProductsResult"/>.
/// </remarks>
public class ListProductsQuery : IRequest<ListProductsResult>
{
     
      public string Filter { get; set; }
      public int Page { get; set; }
      public int PageSize { get; set; }
}
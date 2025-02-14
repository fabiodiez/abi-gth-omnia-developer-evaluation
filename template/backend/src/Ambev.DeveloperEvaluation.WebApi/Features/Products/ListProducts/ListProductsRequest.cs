namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.ListProducts;

/// <summary>
/// Request for listing products.
/// </summary>
public class ListProductsRequest
{ 
     public string Filter { get; set; }
     public int Page { get; set; }
     public int PageSize { get; set; }
}
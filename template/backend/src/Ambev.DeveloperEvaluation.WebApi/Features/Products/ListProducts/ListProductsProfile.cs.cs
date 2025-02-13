using AutoMapper;
using Ambev.DeveloperEvaluation.Application.Products.ListProducts;
using Ambev.DeveloperEvaluation.WebApi.Features.Products.ListProducts;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.ListProducts;

/// <summary>
/// Profile for mapping between ListProductsResult and ListProductsResponse.
/// </summary>
public class ListProductsProfile : Profile
{
    public ListProductsProfile()
    {
        CreateMap<ListProductsResult, ListProductsResponse>();
        CreateMap<ProductDto, ProductDto>(); // Mapeamento direto, se necessário.
    }
}
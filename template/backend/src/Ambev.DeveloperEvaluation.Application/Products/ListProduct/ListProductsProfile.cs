using AutoMapper;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Application.Products.ListProducts;

namespace Ambev.DeveloperEvaluation.Application.Products.ListProducts;

/// <summary>
/// Profile for mapping between Product entity and ProductDto.
/// </summary>
public class ListProductsProfile : Profile
{
    public ListProductsProfile()
    {
        CreateMap<Product, ProductDto>();
    }
}
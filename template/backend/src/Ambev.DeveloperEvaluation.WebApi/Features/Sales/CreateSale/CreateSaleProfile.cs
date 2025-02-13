using AutoMapper;
using Ambev.DeveloperEvaluation.Application.Sales.CreateSale;
using Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale;
using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale;

/// <summary>
/// Profile for mapping between Application and API CreateSale responses
/// </summary>
public class CreateSaleProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for CreateSale feature
    /// </summary>
    public CreateSaleProfile()
    {
        CreateMap<CreateSaleRequest, CreateSaleCommand>();
        CreateMap<CreateSaleResult, CreateSaleResponse>();


        // Mapeamento para a lista de itens:
        CreateMap<CreateSaleRequest, CreateSaleCommand>()
            .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src.Items));  

        CreateMap<SaleItemRequest, SaleItem>();  

        CreateMap<CreateSaleResult, CreateSaleResponse>();
        CreateMap<CreateSaleResponse, CreateSaleResult>();  
        CreateMap<SaleItem, SaleItem>();  

        CreateMap<CreateSaleResponse, CreateSaleResult>()
           .ForMember(dest => dest.SaleNumber, opt => opt.MapFrom(src => src.SaleNumber));
        
        CreateMap<CreateSaleCommand, Sale>()
          .ForMember(dest => dest.SaleNumber, opt => opt.Ignore());

    }
}
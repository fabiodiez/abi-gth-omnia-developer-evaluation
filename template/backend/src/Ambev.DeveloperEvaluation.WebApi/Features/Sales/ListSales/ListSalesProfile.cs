using AutoMapper;
using Ambev.DeveloperEvaluation.Application.Sales.ListSales;
using Ambev.DeveloperEvaluation.WebApi.Features.Sales.ListSales;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.ListSales;

/// <summary>
/// Profile for mapping between ListSalesResult and ListSalesResponse.
/// </summary>
public class ListSalesProfile : Profile
{
    public ListSalesProfile()
    {
        CreateMap<ListSalesRequest, ListSalesQuery>();       
        CreateMap<ListSalesResult, ListSalesResponse>();       
    }
}
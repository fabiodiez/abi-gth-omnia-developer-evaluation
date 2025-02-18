﻿using AutoMapper;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Application.Sales.UpdateSale;

namespace Ambev.DeveloperEvaluation.Application.Sales.UpdateSale;

/// <summary>
/// Profile for mapping between UpdateSaleCommand and Sale entity.
/// </summary>
public class UpdateSaleProfile : Profile
{
    public UpdateSaleProfile()
    {
        CreateMap<UpdateSaleCommand, Sale>()
           .ForMember(dest => dest.SaleItems, opt => opt.MapFrom(src => src.SaleItems));
        CreateMap<UpdateSaleItemCommand, SaleItem>();
    }
}
using MediatR;
using Ambev.DeveloperEvaluation.Application.Sales.UpdateSale;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Ambev.DeveloperEvaluation.Domain.Specifications;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Sales.UpdateSale;

/// <summary>
/// Handler for updating a Sale.
/// </summary>
public class UpdateSaleHandler : IRequestHandler<UpdateSaleCommand, UpdateSaleResult>
{
    private readonly ISaleRepository _saleRepository;
    private readonly IMapper _mapper;

    public UpdateSaleHandler(ISaleRepository saleRepository, IMapper mapper)
    {
        _saleRepository = saleRepository;
        _mapper = mapper;
    }

    public async Task<UpdateSaleResult> Handle(UpdateSaleCommand request, CancellationToken cancellationToken)
    {
        var sale = await _saleRepository.GetByIdAsync(request.Id, cancellationToken);

        if (sale == null)
        {
            return new UpdateSaleResult
            {
                Success = false,
                Message = "Sale not found."
            };
        }

        _mapper.Map(request, sale);

        foreach (var saleItem in sale.SaleItems)
        {
            if (saleItem.Quantity > 20)
            {
                throw new InvalidOperationException($"Maximum quantity of 20 items per product exceeded for product ID: {saleItem.ProductId}");
            }

            saleItem.Discount = new SaleDiscountSpecification().CalculateDiscount(saleItem.Quantity, saleItem.UnitPrice);
            saleItem.Update(saleItem.Quantity, saleItem.UnitPrice, saleItem.Discount);
        }

        await _saleRepository.UpdateAsync(sale, cancellationToken);

        return new UpdateSaleResult
        {
            Success = true,
            Message = "Sale updated successfully."
        };
    }
}

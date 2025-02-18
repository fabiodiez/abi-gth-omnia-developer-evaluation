﻿using AutoMapper;
using MediatR;
using FluentValidation;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Common.Security;
using Ambev.DeveloperEvaluation.Domain.Enums;
using Ambev.DeveloperEvaluation.Domain.Specifications;

namespace Ambev.DeveloperEvaluation.Application.Sales.CreateSale;

/// <summary>
/// Handler for processing CreateSaleCommand requests
/// </summary>
public class CreateSaleHandler : IRequestHandler<CreateSaleCommand, CreateSaleResult>
{
    private readonly ISaleRepository _saleRepository;
    private readonly IUserRepository _userRepository;
    private readonly IProductRepository _productRepository;

    private readonly IMapper _mapper;

    /// <summary>
    /// Initializes a new instance of CreateSaleHandler
    /// </summary>
    /// <param name="saleRepository">The Sale repository</param>
    /// <param name="mapper">The AutoMapper instance</param>
    /// <param name="validator">The validator for CreateSaleCommand</param>
    public CreateSaleHandler(ISaleRepository saleRepository, IMapper mapper, IUserRepository userRepository, IProductRepository productRepository)
    {
        _saleRepository = saleRepository;
        _mapper = mapper;
        _userRepository = userRepository;
        _productRepository = productRepository;
    }

    /// <summary>
    /// Handles the CreateSaleCommand request
    /// </summary>
    /// <param name="command">The CreateSale command</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The created Sale details</returns>
    public async Task<CreateSaleResult> Handle(CreateSaleCommand command, CancellationToken cancellationToken)
    {
        var validator = new CreateSaleCommandValidator();
        var validationResult = await validator.ValidateAsync(command, cancellationToken);

        if (!validationResult.IsValid)
            throw new ValidationException(validationResult.Errors);
        
        var customer = await _userRepository.GetByIdAsync(command.CustomerId, cancellationToken);
        if (customer.Role != UserRole.Customer)
            throw new InvalidOperationException($"The user {customer.Username} is not a customer");

        var sale = _mapper.Map<Sale>(command);

        foreach (var saleItem in sale.SaleItems)
        {
            if (saleItem.Quantity > 20)
            {
                throw new InvalidOperationException($"Maximum quantity of 20 items per product exceeded for product ID: {saleItem.ProductId}");
            }

            var product = await _productRepository.GetByIdAsync(saleItem.ProductId, cancellationToken);
            saleItem.UnitPrice = product.Price;

            saleItem.Discount = new SaleDiscountSpecification().CalculateDiscount(saleItem.Quantity, saleItem.UnitPrice);
            saleItem.Update(saleItem.Quantity, saleItem.UnitPrice,saleItem.Discount);
        }

        sale.CalculateTotal();

        var createdSale = await _saleRepository.CreateAsync(sale, cancellationToken);
        var result = _mapper.Map<CreateSaleResult>(createdSale);
        return result;
    }
}

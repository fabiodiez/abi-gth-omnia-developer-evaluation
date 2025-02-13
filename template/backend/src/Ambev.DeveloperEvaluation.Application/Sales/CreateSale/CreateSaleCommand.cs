using Ambev.DeveloperEvaluation.Common.Security;
using Ambev.DeveloperEvaluation.Common.Validation;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Validation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Sales.CreateSale;

/// <summary>
/// Command for creating a new Sale.
/// </summary>
/// <remarks>
/// This command is used to capture the required data for creating a Sale, 
/// It implements <see cref="IRequest{TResponse}"/> to initiate the request 
/// that returns a <see cref="CreateSaleResult"/>.
/// 
/// The data provided in this command is validated using the 
/// <see cref="CreateSaleCommandValidator"/> which extends 
/// <see cref="AbstractValidator{T}"/> to ensure that the fields are correctly 
/// populated and follow the required rules.
/// </remarks>
public class CreateSaleCommand : IRequest<CreateSaleResult>
{
    /// <summary>
    /// Gets or sets the date and time when the sale was made.
    /// </summary>
    public DateTime SaleDate { get; set; } = DateTime.UtcNow;

    /// <summary>
    /// Gets or sets the unique identifier of the customer who made the purchase.
    /// </summary>
    public Guid CustomerId { get; set; }

    /// <summary>
    /// Gets or sets the total amount of the sale.
    /// </summary>
    public decimal TotalAmount { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier of the branch where the sale was made.
    /// </summary>
    public Guid BranchId { get; set; }

    /// <summary>
    /// Gets or sets the customer associated with the sale.
    /// </summary>
    public User Customer { get; set; }

    /// <summary>
    /// Gets or sets the branch where the sale was made.
    /// </summary>
    public Branch Branch { get; set; }

    /// <summary>
    /// Gets or sets the collection of items included in the sale.
    /// </summary>
    public ICollection<SaleItem> Items { get; set; }    

    
}
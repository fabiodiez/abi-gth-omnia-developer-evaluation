using Ambev.DeveloperEvaluation.Common.Security;
using Ambev.DeveloperEvaluation.Common.Validation;
using Ambev.DeveloperEvaluation.Domain.Common;
using Ambev.DeveloperEvaluation.Domain.Validation;
using System.Text.Json.Serialization;

namespace Ambev.DeveloperEvaluation.Domain.Entities;

/// <summary>
/// Represents an item in a sales transaction, linking a product to a sale with details such as quantity, price, and discount.
/// This entity follows domain-driven design principles and includes business rules validation.
/// </summary>
public class SaleItem : BaseEntity 
{
    /// <summary>
    /// Gets or sets the ID of the sale to which this item belongs.
    /// </summary>
    public Guid SaleId { get; set; }

    /// <summary>
    /// Gets or sets the ID of the product associated with this sale item.
    /// </summary>
    public Guid ProductId { get; set; }

    /// <summary>
    /// Gets or sets the quantity of the product sold in this item.
    /// Must be a positive integer and cannot exceed the maximum allowed quantity per product.
    /// </summary>
    public int Quantity { get; set; }

    /// <summary>
    /// Gets or sets the unit price of the product at the time of the sale.
    /// Must be a positive value.
    /// </summary>
    public decimal UnitPrice { get; set; }

    /// <summary>
    /// Gets or sets the discount applied to this item.
    /// Must be a non-negative value and cannot exceed the total item amount.
    /// </summary>
    public decimal Discount { get; set; }

    /// <summary>
    /// Gets or sets the total amount for this item, calculated as (UnitPrice * Quantity) - Discount.
    /// </summary>
    public decimal TotalItemAmount { get; set; }

    /// <summary>
    /// Gets or sets the sale to which this item belongs.
    /// </summary>
    [JsonIgnore]
    public Sale Sale { get; set; }

    /// <summary>
    /// Gets or sets the product associated with this sale item.
    /// </summary>
    public Product Product { get; set; }


    /// <summary>
    /// Gets or sets status of this sale item.
    /// </summary>
    public bool IsCancelled { get; set; }


    /// <summary>
    /// Initializes a new instance of the <see cref="SaleItem"/> class.
    /// </summary>
    public SaleItem()
    {
    }

    /// <summary>
    /// Performs validation of the sale item entity using the SaleItemValidator rules.
    /// </summary>
    /// <returns>
    /// A <see cref="ValidationResultDetail"/> containing:
    /// - IsValid: Indicates whether all vlaidation rules pased
    /// - Errors: Collection of validation errors if any rules failed
    /// </returns>
    /// <remarks>
    /// <listheader>The validation includes checking:</listheader>
    /// <list type="bullet">Quantity must be positive and within allowed limits</list>
    /// <list type="bullet">UnitPrice must be positive</list>
    /// <list type="bullet">Discount must be non-negative and cannot exceed the total item amount</list>
    /// <list type="bullet">TotalItemAmount must be correctly calculated</list>
    /// </remarks>
    public ValidationResultDetail Validate()
    {
        var validator = new SaleItemValidator();
        var result = validator.Validate(this);
        return new ValidationResultDetail
        {
            IsValid = result.IsValid,
            Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
        };
    }

    /// <summary>
    /// Updates the sale item's information and recalculates the total item amount.
    /// </summary>
    /// <param name="quantity">The new quantity for the item.</param>
    /// <param name="unitPrice">The new unit price for the item.</param>
    /// <param name="discount">The new discount for the item.</param>
    public void Update(int quantity, decimal unitPrice, decimal discount)
    {
        Quantity = quantity;
        UnitPrice = unitPrice;
        Discount = discount;
        TotalItemAmount = (unitPrice * quantity) - discount;
    }
}
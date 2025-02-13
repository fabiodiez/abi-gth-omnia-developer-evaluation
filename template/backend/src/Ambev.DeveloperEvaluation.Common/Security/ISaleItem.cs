using Ambev.DeveloperEvaluation.Common.Validation;

namespace Ambev.DeveloperEvaluation.Domain.Entities
{
    /// <summary>
    /// Defines the contract for a sale item, linking a product to a sale with details such as quantity, price, and discount.
    /// </summary>
    public interface ISaleItem
    {
        /// <summary>
        /// Gets the ID of the sale to which this item belongs.
        /// </summary>
        Guid Id { get; set; }

        /// <summary>
        /// Gets the ID of the sale to which this item belongs.
        /// </summary>
        Guid SaleId { get; set; }

        /// <summary>
        /// Gets the ID of the product associated with this sale item.
        /// </summary>
        Guid ProductId { get; set; }

        /// <summary>
        /// Gets the quantity of the product sold in this item.
        /// Must be a positive integer and cannot exceed the maximum allowed quantity per product.
        /// </summary>
        int Quantity { get; set; }

        /// <summary>
        /// Gets the unit price of the product at the time of the sale.
        /// Must be a positive value.
        /// </summary>
        decimal UnitPrice { get; set; }

        /// <summary>
        /// Gets the discount applied to this item.
        /// Must be a non-negative value and cannot exceed the total item amount.
        /// </summary>
        decimal Discount { get; set; }

        /// <summary>
        /// Gets the total amount for this item, calculated as (UnitPrice * Quantity) - Discount.
        /// </summary>
        decimal TotalItemAmount { get; set; }

        /// <summary>
        /// Validates the sale item entity using the SaleItemValidator rules.
        /// </summary>
        /// <returns>A ValidationResultDetail indicating whether the entity is valid and listing any validation errors.</returns>
        ValidationResultDetail Validate();
        
        /// <summary>
        /// Updates the sale item's information and recalculates the total item amount.
        /// </summary>
        /// <param name="quantity">The new quantity for the item.</param>
        /// <param name="unitPrice">The new unit price for the item.</param>
        /// <param name="discount">The new discount for the item.</param>
        void Update(int quantity, decimal unitPrice, decimal discount);
    }
}

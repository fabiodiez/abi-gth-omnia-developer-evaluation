using Ambev.DeveloperEvaluation.Common.Security;
using Ambev.DeveloperEvaluation.Common.Validation;
using Ambev.DeveloperEvaluation.Domain.Common;
using Ambev.DeveloperEvaluation.Domain.Validation;

namespace Ambev.DeveloperEvaluation.Domain.Entities;

/// <summary>
/// Represents a product in the system, which can be sold in sales transactions.
/// This entity follows domain-driven design principles and includes business rules validation.
/// </summary>
public class Product : BaseEntity
{
    /// <summary>
    /// Gets or sets the name of the product.
    /// Must not be null or empty and should be unique within the system.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the description of the product.
    /// Provides additional details about the product.
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the price of the product.
    /// Must be a positive value and represents the unit price in the system's currency.
    /// </summary>
    public decimal Price { get; set; }    

    /// <summary>
    /// Performs validation of the product entity using the ProductValidator rules.
    /// </summary>
    /// <returns>
    /// A <see cref="ValidationResultDetail"/> containing:
    /// - IsValid: Indicates whether all validation rules passed
    /// - Errors: Collection of validation errors if any rules failed
    /// </returns>
    /// <remarks>
    /// <listheader>The validation includes checking:</listheader>
    /// <list type="bullet">Name format and length</list>
    /// <list type="bullet">Description length</list>
    /// <list type="bullet">Price positivity</list>
    /// </remarks>
    public ValidationResultDetail Validate()
    {
        var validator = new ProductValidator();
        var result = validator.Validate(this);
        return new ValidationResultDetail
        {
            IsValid = result.IsValid,
            Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
        };
    }

    /// <summary>
    /// Updates the product's information and sets the last updated timestamp.
    /// </summary>
    /// <param name="name">The new name for the product.</param>
    /// <param name="description">The new description for the product.</param>
    /// <param name="price">The new price for the product.</param>
    public void Update(string name, string description, decimal price)
    {
        Name = name;
        Description = description;
        Price = price;       
    }
}
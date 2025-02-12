namespace Ambev.DeveloperEvaluation.Common.Security
{
    /// <summary>
    /// Defines the contract for representing a product.
    /// </summary>
    public interface IProduct
    {
        /// <summary>
        /// Gets the unique identifier of the product.
        /// </summary>
        Guid Id { get; }

        /// <summary>
        /// Gets or sets the name of the product.
        /// Must not be null or empty and should be unique within the system.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets or sets the description of the product.
        /// Provides additional details about the product.
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// Gets or sets the price of the product.
        /// Must be a positive value and represents the unit price in the system's currency.
        /// </summary>
        public decimal Price { get; }
    }
}
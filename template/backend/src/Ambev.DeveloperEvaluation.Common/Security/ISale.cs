using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Common.Security
{
    /// <summary>
    /// Defines the contract for representing a product.
    /// </summary>
    public interface ISale
    {
        /// <summary>
        /// Gets the unique identifier of the product.
        /// </summary>
        Guid Id { get; }

        public int SaleNumber { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the sale was made.
        /// </summary>
        public DateTime SaleDate { get; set; }

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
        /// Gets or sets a boolean value indicating whether the sale is cancelled.
        /// </summary>
        public bool IsCancelled { get; set; }

        /// <summary>
        /// Gets or sets the customer associated with the sale.
        /// </summary>
        public IUser Customer { get; set; }

        /// <summary>
        /// Gets or sets the branch where the sale was made.
        /// </summary>
        public IBranch Branch { get; set; }

        /// <summary>
        /// Gets or sets the collection of items included in the sale.
        /// </summary>
        public ICollection<ISaleItem> SaleItems { get; set; }
    }
}
using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale
{

    /// <summary>
    /// API response model for CreateSale operation
    /// </summary>
    /// 
    public class CreateSaleResponse
    {
        /// <summary>
        /// The unique identifier of the sale created
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// The number of the sale
        /// </summary>
        public int SaleNumber { get; set; }

        /// <summary>
        /// The sale date
        /// </summary>
        public DateTime SaleDate { get; set; }

        /// <summary>
        /// The customer's unique identifier
        /// </summary>
        public Guid CustomerId { get; set; }
               
        /// <summary>
        /// The total amount of the sale
        /// </summary>
        public decimal TotalAmount { get; set; }

        /// <summary>
        /// The branch's unique identifier
        /// </summary>
        public Guid BranchId { get; set; }

        /// <summary>
        /// The sale status
        /// </summary>
        public bool IsCancelled { get; set; }

        /// <summary>
        /// the list of items included in the sale
        /// </summary>
        public ICollection<ISaleItem> SaleItems { get; set; }

    }
}

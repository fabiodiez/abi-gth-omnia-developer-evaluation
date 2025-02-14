using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Domain.Specifications
{
    public class SaleDiscountSpecification
    {
        public decimal CalculateDiscount(int quantity, decimal unitPrice)
        {
            decimal discountPercentage = 0;
            if (quantity >= 4 && quantity < 10)
            {
                discountPercentage = 0.10M; 
            }
            else if (quantity >= 10 && quantity <= 20)
            {
                discountPercentage = 0.20M;
            }
            return quantity * unitPrice * discountPercentage;
        }
    }
}

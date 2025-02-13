
using Ambev.DeveloperEvaluation.Application.Sales.ListSales;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Sales.GetSale;

/// <summary>
/// Validator for ListSalesQuery
/// </summary>
public class ListSalesValidator : AbstractValidator<ListSalesQuery>
{
    /// <summary>
    /// Initializes validation rules for ListSalesQuery
    /// </summary>
    public ListSalesValidator()
    { 
    }
}

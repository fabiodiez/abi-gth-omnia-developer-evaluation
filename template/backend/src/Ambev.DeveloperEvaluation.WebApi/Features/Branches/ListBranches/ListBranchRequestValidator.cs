using Ambev.DeveloperEvaluation.WebApi.Features.Branches.ListBranches;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Branches.GetBranch;

/// <summary>
/// Validator for GetBranchRequest
/// </summary>
public class ListBranchesRequestValidator : AbstractValidator<ListBranchesRequest>
{
    /// <summary>
    /// Initializes validation rules for GetBranchRequest
    /// </summary>
    public ListBranchesRequestValidator()
    {   
    }
}

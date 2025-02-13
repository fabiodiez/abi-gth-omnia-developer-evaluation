using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Branches.GetBranch;

/// <summary>
/// Validator for GetBranchCommand
/// </summary>
public class ListBranchValidator : AbstractValidator<GetBranchCommand>
{
    /// <summary>
    /// Initializes validation rules for GetBranchCommand
    /// </summary>
    public ListBranchValidator()
    {
       
    }
}

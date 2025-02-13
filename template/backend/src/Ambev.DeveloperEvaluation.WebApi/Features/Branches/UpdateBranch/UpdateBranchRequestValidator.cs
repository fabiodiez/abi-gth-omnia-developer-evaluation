using FluentValidation;
using Ambev.DeveloperEvaluation.WebApi.Features.Branches.UpdateBranch;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Branches.UpdateBranch;

/// <summary>
/// Validator for UpdateBranchRequest.
/// </summary>
public class UpdateBranchRequestValidator : AbstractValidator<UpdateBranchRequest>
{
    /// <summary>
    /// Initializes a new instance of the UpdateBranchRequest with defined validation rules.
    /// </summary>
    /// <remarks>
    /// Validation rules include:
    /// - Id: Required
    /// - Name: Required, maximum length of 100 characters
    /// </remarks
    public UpdateBranchRequestValidator()
    {
        RuleFor(request => request.Id).NotEmpty().WithMessage("Branch ID is required.");
        RuleFor(request => request.Name).NotEmpty().WithMessage("Branch name is required.")
                                       .MaximumLength(100).WithMessage("Branch name must not exceed 100 characters.");       
    }
}
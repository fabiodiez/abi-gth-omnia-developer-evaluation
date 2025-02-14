using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Branches.UpdateBranch;

/// <summary>
/// Validator for UpdateBranchCommand.
/// </summary>
public class UpdateBranchCommandValidator : AbstractValidator<UpdateBranchCommand>
{
    /// <summary>
    /// Initializes a new instance of the UpdateBranchCommandValidator with defined validation rules.
    /// </summary>
    /// <remarks>
    /// Validation rules include:
    /// - Name: Required, Id, Branch name must not exceed 100 characters.
    public UpdateBranchCommandValidator()
    {
        RuleFor(branch => branch.Id).NotEmpty().WithMessage("Branch Id is required.");
        RuleFor(Branch => Branch.Name)
                .NotEmpty().WithMessage("Branch name is required.")
                .MaximumLength(100).WithMessage("Branch name must not exceed 100 characters.");
    }


}
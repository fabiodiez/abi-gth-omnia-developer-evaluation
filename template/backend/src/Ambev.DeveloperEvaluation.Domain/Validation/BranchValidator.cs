using Ambev.DeveloperEvaluation.Domain.Entities;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.Domain.Validation;

/// <summary>
/// Validator for the Branch entity.
/// </summary>
public class BranchValidator : AbstractValidator<string>
{
    public BranchValidator()
    {
        RuleFor(Name => Name)
            .NotEmpty().WithMessage("Branch name is required.")
            .MaximumLength(100).WithMessage("Branch name must not exceed 100 characters.");

    }
}
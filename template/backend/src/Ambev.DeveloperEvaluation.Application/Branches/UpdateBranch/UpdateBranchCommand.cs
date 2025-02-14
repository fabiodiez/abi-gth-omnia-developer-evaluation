using MediatR;
using Ambev.DeveloperEvaluation.Common.Validation;

namespace Ambev.DeveloperEvaluation.Application.Branches.UpdateBranch;

/// <summary>
/// Command for updating a Branch.
/// </summary>
public class UpdateBranchCommand : IRequest<UpdateBranchResult>
{
    /// <summary>
    /// Gets or sets the Id of the Branch to be updated.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Gets or sets the Name of the Branch to be updated.
    /// </summary>
    public string Name { get; set; } = string.Empty;


    public ValidationResultDetail Validate()
    {
        var validator = new UpdateBranchCommandValidator();
        var result = validator.Validate(this);
        return new ValidationResultDetail
        {
            IsValid = result.IsValid,
            Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
        };
    }
}
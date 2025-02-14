using Ambev.DeveloperEvaluation.Common.Security;
using Ambev.DeveloperEvaluation.Common.Validation;
using Ambev.DeveloperEvaluation.Domain.Common;
using Ambev.DeveloperEvaluation.Domain.Validation;

namespace Ambev.DeveloperEvaluation.Domain.Entities;

/// <summary>
/// Represents a branch in the system, which is a physical location where sales are made.
/// This entity follows domain-driven design principles and includes business rules validation.
/// </summary>
public class Branch : BaseEntity, IBranch
{
    /// <summary>
    /// Gets or sets the name of the branch.
    /// Must not be null or empty and should be unique within the system.
    /// </summary>
    public string Name { get; set; } = string.Empty;


    /// <summary>
    /// Performs validation of the branch entity using the BranchValidator rules.
    /// </summary>
    /// <returns>
    /// A <see cref="ValidationResultDetail"/> containing:
    /// - IsValid: Indicates whether all validation rules passed
    /// - Errors: Collection of validation errors if any rules failed
    /// </returns>
    /// <remarks>
    /// <listheader>The validation includes checking:</listheader>
    /// <list type="bullet">Name format and length</list>
    /// <list type="bullet">Uniqueness of the branch name</list>
    /// </remarks>
    public ValidationResultDetail Validate()
    {
        var validator = new BranchValidator();
        var result = validator.Validate(this.Name);
        return new ValidationResultDetail
        {
            IsValid = result.IsValid,
            Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
        };
    }

    /// <summary>
    /// Updates the branch's name and sets the last updated timestamp.
    /// </summary>
    /// <param name="name">The new name for the branch.</param>
    public void UpdateName(string name)
    {
        Name = name;
    }
}
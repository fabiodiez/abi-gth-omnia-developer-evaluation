namespace Ambev.DeveloperEvaluation.WebApi.Features.Branches.UpdateBranch;

/// <summary>
/// Request for updating a Branch.
/// </summary>
public class UpdateBranchRequest
{
    /// <summary>
    /// The unique identifier of the branch to update
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Gets or sets the name of the branch to update. Must be unique and contain only valid characters.
    /// </summary>
    public string Name { get; set; } = string.Empty;
}
namespace Ambev.DeveloperEvaluation.WebApi.Features.Branches.CreateBranch;

/// <summary>
/// Represents a request to create a new branch in the system.
/// </summary>
public class CreateBranchRequest
{
    /// <summary>
    /// Gets or sets the name of the branch. Must be unique and contain only valid characters.
    /// </summary>
    public string Name { get; set; } = string.Empty;     

}
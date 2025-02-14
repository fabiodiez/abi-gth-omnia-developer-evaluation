namespace Ambev.DeveloperEvaluation.WebApi.Features.Branches.UpdateBranch;

/// <summary>
/// Response for updating a Branch.
/// </summary>
public class UpdateBranchResponse
{
    public bool Success { get; set; }
    public string Message { get; set; } = string.Empty;
}
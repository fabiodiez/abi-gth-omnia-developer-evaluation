namespace Ambev.DeveloperEvaluation.Application.Branches.UpdateBranch;

/// <summary>
/// Result for updating a Branch.
/// </summary>
public class UpdateBranchResult
{
    public bool Success { get; set; }
    public string Message { get; set; } = string.Empty;
}
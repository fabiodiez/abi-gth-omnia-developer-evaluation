namespace Ambev.DeveloperEvaluation.Application.Branches.ListBranches;

/// <summary>
/// Result for listing branches.
/// </summary>
public class ListBranchesResult
{
    public IEnumerable<BranchDto> Branches { get; set; } = new List<BranchDto>();
}

/// <summary>
/// DTO for Branch.
/// </summary>
public class BranchDto
{
    /// <summary>
    /// The unique identifier of the Branch
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// The Branch's full name
    /// </summary>
    public string Name { get; set; } = string.Empty;
}
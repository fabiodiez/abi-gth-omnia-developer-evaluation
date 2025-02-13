namespace Ambev.DeveloperEvaluation.WebApi.Features.Branches.ListBranches;

/// <summary>
/// Response for listing branches.
/// </summary>
public class ListBranchesResponse
{
    public IEnumerable<BranchDto> Branches { get; set; } = new List<BranchDto>();
}

/// <summary>
/// DTO for Branch.
/// </summary>
public class BranchDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    
}
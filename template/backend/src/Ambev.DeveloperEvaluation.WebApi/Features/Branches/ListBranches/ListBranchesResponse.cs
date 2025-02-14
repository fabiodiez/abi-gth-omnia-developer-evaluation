using Ambev.DeveloperEvaluation.Application.Branches.ListBranches;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Branches.ListBranches;

/// <summary>
/// Response for listing branches.
/// </summary>
public class ListBranchesResponse
{
    public IEnumerable<BranchDto> Branches { get; set; } = new List<BranchDto>();
}


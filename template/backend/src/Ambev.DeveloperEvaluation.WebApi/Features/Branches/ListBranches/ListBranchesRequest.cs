namespace Ambev.DeveloperEvaluation.WebApi.Features.Branches.ListBranches;

/// <summary>
/// Request for listing branches.
/// </summary>
public class ListBranchesRequest
{
     
     public string Filter { get; set; }
     public int Page { get; set; }
     public int PageSize { get; set; }
}
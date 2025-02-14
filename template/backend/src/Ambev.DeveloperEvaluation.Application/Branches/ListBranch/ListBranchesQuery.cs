using Ambev.DeveloperEvaluation.Application.Branches.ListBranches;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Branches.ListBranches;

/// <summary>
/// Query for listing branches.
/// </summary>
public class ListBranchesQuery : IRequest<ListBranchesResult>
{
     public string Filter { get; set; }
     public int Page { get; set; }
     public int PageSize { get; set; }
}
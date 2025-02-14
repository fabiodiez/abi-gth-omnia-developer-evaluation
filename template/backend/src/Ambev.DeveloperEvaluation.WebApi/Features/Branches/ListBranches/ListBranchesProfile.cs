using AutoMapper;
using Ambev.DeveloperEvaluation.Application.Branches.ListBranches;
using Ambev.DeveloperEvaluation.WebApi.Features.Branches.ListBranches;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Branches.ListBranches;

/// <summary>
/// Profile for mapping between ListBranchesResult and ListBranchesResponse.
/// </summary>
public class ListBranchesProfile : Profile
{
    public ListBranchesProfile()
    {
        CreateMap<ListBranchesRequest, ListBranchesQuery>();
        CreateMap<ListBranchesResult, ListBranchesResponse>();
    }
}
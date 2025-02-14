using AutoMapper;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Application.Branches.ListBranches;

namespace Ambev.DeveloperEvaluation.Application.Branches.ListBranches;

/// <summary>
/// Profile for mapping between Branch entity and BranchDto.
/// </summary>
public class ListBranchesProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for ListBranch operation
    /// </summary>
    public ListBranchesProfile()
    {
        CreateMap<Branch, BranchDto>();
    }
}
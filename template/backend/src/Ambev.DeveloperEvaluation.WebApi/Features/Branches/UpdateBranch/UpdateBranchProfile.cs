using AutoMapper;
using Ambev.DeveloperEvaluation.Application.Branches.UpdateBranch;
using Ambev.DeveloperEvaluation.WebApi.Features.Branches.UpdateBranch;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Branches.UpdateBranch;

/// <summary>
/// Profile for mapping between UpdateBranchRequest, UpdateBranchCommand, UpdateBranchResult, and UpdateBranchResponse.
/// </summary>
public class UpdateBranchProfile : Profile
{
    public UpdateBranchProfile()
    {
        CreateMap<UpdateBranchRequest, UpdateBranchCommand>();
        CreateMap<UpdateBranchResult, UpdateBranchResponse>();
    }
}
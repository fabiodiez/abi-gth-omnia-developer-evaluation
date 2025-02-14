using MediatR;
using Ambev.DeveloperEvaluation.Application.Branches.UpdateBranch;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;

namespace Ambev.DeveloperEvaluation.Application.Branches.UpdateBranch;

/// <summary>
/// Handler for updating a Branch.
/// </summary>
public class UpdateBranchHandler : IRequestHandler<UpdateBranchCommand, UpdateBranchResult>
{
    private readonly IBranchRepository _branchRepository;

    public UpdateBranchHandler(IBranchRepository branchRepository)
    {
        _branchRepository = branchRepository;
    }

    public async Task<UpdateBranchResult> Handle(UpdateBranchCommand request, CancellationToken cancellationToken)
    {
        var branch = await _branchRepository.GetByIdAsync(request.Id, cancellationToken);

        if (branch == null)
        {
            return new UpdateBranchResult
            {
                Success = false,
                Message = "Branch not found."
            };
        }

        branch.Name = request.Name;       

        await _branchRepository.UpdateAsync(branch, cancellationToken);

        return new UpdateBranchResult
        {
            Success = true,
            Message = "Branch updated successfully."
        };
    }
}
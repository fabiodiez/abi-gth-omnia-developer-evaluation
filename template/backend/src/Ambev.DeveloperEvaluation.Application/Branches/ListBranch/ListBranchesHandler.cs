using MediatR;
using Ambev.DeveloperEvaluation.Application.Branches.ListBranches;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Branches.ListBranches;

/// <summary>
/// Handler for listing branches.
/// </summary>
public class ListBranchesHandler : IRequestHandler<ListBranchesQuery, ListBranchesResult>
{
    private readonly IBranchRepository _branchRepository;
    private readonly IMapper _mapper;

    /// <summary>
    /// Initializes a new instance of ListBranchesHandler
    /// </summary>
    /// <param name="BranchRepository">The Branch repository</param>
    /// <param name="mapper">The AutoMapper instance</param>
    /// <param name="validator">The validator for GetBranchCommand</param>
    public ListBranchesHandler(IBranchRepository branchRepository, IMapper mapper)
    {
        _branchRepository = branchRepository;
        _mapper = mapper;
    }

    /// <summary>
    /// Handles the ListBranchesQuery request
    /// </summary>
    /// <param name="request">The GetBranch command</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The Branch details if found</returns>
    public async Task<ListBranchesResult> Handle(ListBranchesQuery request, CancellationToken cancellationToken)
    {
        var branches = await _branchRepository.GetAllAsync(cancellationToken);

        var branchDtos = _mapper.Map<List<BranchDto>>(branches); 

        return new ListBranchesResult
        {
            Branches = branchDtos
        };
    }
}
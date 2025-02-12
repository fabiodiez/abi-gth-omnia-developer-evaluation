namespace Ambev.DeveloperEvaluation.WebApi.Features.Branches.CreateBranch
{

    /// <summary>
    /// API response model for CreateBranch operation
    /// </summary>
    public class CreateBranchResponse
    {
        /// <summary>
        /// The unique identifier of the branch created 
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// The branch's name
        /// </summary>
        public string Name { get; set; } = string.Empty;
    }
}

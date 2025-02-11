namespace Ambev.DeveloperEvaluation.Common.Security
{
    /// <summary>
    /// Defines the contract for representing a branch.
    /// </summary>
    public interface IBranch
    {
        /// <summary>
        /// Gets the unique identifier of the branch.
        /// </summary>
        Guid Id { get; }

        /// <summary>
        /// Gets the name of the branch.
        /// </summary>
        string Name { get; }
    }
}
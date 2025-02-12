using Ambev.DeveloperEvaluation.Domain.Enums;
using Ambev.DeveloperEvaluation.Domain.Validation;
using Ambev.DeveloperEvaluation.WebApi.Features.Users.CreateUser;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Branches.CreateBranch
{
    /// <summary>
    /// Validator for CreateUserRequest that defines validation rules for user creation.
    /// </summary>
    public class CreateBranchRequestValidator : AbstractValidator<CreateBranchRequest>
    {
        /// <summary>
        /// Initializes a new instance of the CreateBranchRequestValidator with defined validation rules.
        /// </summary>
        /// <remarks>
        /// Validation rules include:
        /// - Name: Required, maximum length of 100 characters
        /// </remarks>
        public CreateBranchRequestValidator()
        {
            RuleFor(branch => branch.Name).SetValidator(new BranchValidator());                
             
        }
    }
}

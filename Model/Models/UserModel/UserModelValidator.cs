using DotNetCore.Validation;
using FluentValidation;

namespace HRMS.Model
{
    public class UserModelValidator<T> : Validator<T> where T : UserModel
    {
        protected UserModelValidator()
        {
            RuleFor(x => x.FullName).NotEmpty();
            RuleFor(x => x.FullName.Name).NotEmpty();
            RuleFor(x => x.FullName.Surname).NotEmpty();
            RuleFor(x => x.Email).NotEmpty();
        }
    }
}

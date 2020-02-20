using FluentValidation;

namespace HRMS.Model
{
    public sealed class UpdateUserModelValidator : UserModelValidator<UpdateUserModel>
    {
        public UpdateUserModelValidator()
        {
            RuleFor(x => x.UserId).NotEmpty();
        }
    }
}

using FluentValidation;
using WebApplication.Domain.Entities;

namespace WebApplication.Service.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(c => c.Username)
                .NotEmpty().WithMessage("Please enter the user name.")
                .NotNull().WithMessage("Please enter the user name.");

            RuleFor(c => c.Email)
                .NotEmpty().WithMessage("Please enter the email.")
                .NotNull().WithMessage("Please enter the email.");

            RuleFor(c => c.Password)
                .NotEmpty().WithMessage("Please enter the password.")
                .NotNull().WithMessage("Please enter the password.");
        }
    }
}

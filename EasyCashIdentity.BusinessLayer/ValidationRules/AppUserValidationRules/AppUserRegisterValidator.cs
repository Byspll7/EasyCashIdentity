using EasyCashIdentity.Dto.Dtos.AppuserDtos;
using EasyCashIdentity.EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentity.BusinessLayer.ValidationRules.AppUserValidationRules
{
    public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDto>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("The name field cannot be empty.");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("The name field can be a maximum of 30 characters.");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("The name field must be at least 2 characters.");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("The surname field cannot be empty.");
            RuleFor(x => x.Email).NotEmpty().WithMessage("The email field cannot be empty.");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Please enter a valid email address.");
            RuleFor(x => x.Username).NotEmpty().WithMessage("The username field cannot be empty.");
            RuleFor(x => x.Password).NotEmpty().WithMessage("The password field cannot be empty.");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("The confirm password field cannot be empty.");
            RuleFor(x => x.ConfirmPassword).Equal(y => y.Password).WithMessage("Passwords do not match.");
        }
    }
}

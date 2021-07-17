using Core.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.FirstName).NotEmpty().WithMessage("Ad boş geçilemez!");
            RuleFor(u => u.FirstName).MinimumLength(3).WithMessage("Ad en az 3 karakterden oluşmalıdır!");
            RuleFor(u => u.FirstName).MaximumLength(20).WithMessage("Ad en fazla 20 karakter olabilir!");

            RuleFor(u => u.LastName).NotEmpty().WithMessage("Soyad boş geçilemez!");
            RuleFor(u => u.LastName).MinimumLength(3).WithMessage("Soyad en az 3 karakterden oluşmalıdır!");
            RuleFor(u => u.LastName).MaximumLength(20).WithMessage("Soyad en fazla 20 karakter olabilir!");

            RuleFor(u => u.Email).NotEmpty().WithMessage("Email boş geçilemez!");
            RuleFor(u => u.Email).MinimumLength(5).WithMessage("Email en az 5 karakterden oluşmalıdır!");
            RuleFor(u => u.Email).MaximumLength(50).WithMessage("Email en fazla 50 karakter olabilir!");

            //RuleFor(u => u.Password).NotEmpty().WithMessage("Şifre boş geçilemez!");
            //RuleFor(u => u.Password).MinimumLength(3).WithMessage("Şifre en az 3 karakterden oluşmalıdır!");
            //RuleFor(u => u.Password).MaximumLength(20).WithMessage("Şifre en fazla 20 karakter olabilir!");
        }
    }
}

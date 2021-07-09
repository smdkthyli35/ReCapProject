using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c => c.CompanyName).NotEmpty().WithMessage("Şirket adı boş geçilemez!");
            RuleFor(c => c.CompanyName).MinimumLength(3).WithMessage("Şirket adı en az 3 karakterden oluşmalıdır !");
            RuleFor(c => c.CompanyName).MaximumLength(50).WithMessage("Şirket adı en fazla 50 karakterden oluşabilir !");
        }
    }
}

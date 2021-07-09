using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class BrandValidator : AbstractValidator<Brand>
    {
        public BrandValidator()
        {
            RuleFor(b => b.BrandName).NotEmpty().WithMessage("Marka adı boş geçilemez!");
            RuleFor(b => b.BrandName).MinimumLength(3).WithMessage("Marka adı en az 3 karakterden oluşmalıdır!");
            RuleFor(b => b.BrandName).MaximumLength(20).WithMessage("Marka adı en fazla 20 karakter olabilir!");
        }
    }
}

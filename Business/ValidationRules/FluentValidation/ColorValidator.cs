using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ColorValidator : AbstractValidator<Color>
    {
        public ColorValidator()
        {
            RuleFor(c => c.ColorName).NotEmpty().WithMessage("Renk adı boş geçilemez!");
            RuleFor(c => c.ColorName).MinimumLength(3).WithMessage("Renk adı en az 3 karakterden oluşmalıdır!");
            RuleFor(c => c.ColorName).MaximumLength(20).WithMessage("Renk adı en fazla 20 karakter olabilir!");
        }
    }
}

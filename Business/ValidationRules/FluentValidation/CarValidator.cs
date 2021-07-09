using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c=>c.CarName).NotEmpty().WithMessage("Araba adı boş geçilemez!");
            RuleFor(c => c.CarName).MinimumLength(3).WithMessage("Araba adı en az 3 karakterden oluşmalıdır.");
            RuleFor(c => c.CarName).MaximumLength(30).WithMessage("Araba adı en fazla 30 karakter olabilir.");
            RuleFor(c => c.DailyPrice).NotEmpty().WithMessage("Günlük fiyat değeri boş geçilemez!");
            RuleFor(c => c.DailyPrice).GreaterThan(0).WithMessage("Günlük fiyat değeri 0'dan büyük olmalıdır!");
            RuleFor(c => c.Description).NotEmpty().WithMessage("Araba açıklaması boş geçilemez!");
            RuleFor(c => c.Description).MinimumLength(20).WithMessage("Araba açıklaması en az 20 karakterden oluşmalıdır.");
            RuleFor(c => c.ModelYear).NotEmpty();
        }
    }
}

using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarImageValidator : AbstractValidator<CarImage>
    {
        public CarImageValidator()
        {
            RuleFor(cimg => cimg.CarId).NotEmpty().WithMessage("Araba id boş geçilemez!");
            //RuleFor(cimg => cimg.CarImageId).NotEmpty().WithMessage("Araba resmi boş geçilemez!");
            //RuleFor(cimg => cimg.ImagePath).NotEmpty().WithMessage("Araba resim yolu boş geçilemez!");
            //RuleFor(cimg => cimg.Date).NotEmpty().WithMessage("Tarih boş geçilemez!");
        }
    }
}

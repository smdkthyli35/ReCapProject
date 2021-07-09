using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class RentalValidator : AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            RuleFor(r => r.CarId).NotEmpty().WithMessage("Araba adı boş geçilemez!");
            RuleFor(r => r.CustomerId).NotEmpty().WithMessage("Şirket adı boş geçilemez!");
            RuleFor(r => r.RentDate).NotEmpty().WithMessage("Kiralama tarihi boş geçilemez!");
            RuleFor(r => r.RentDate).NotEmpty().LessThanOrEqualTo(DateTime.Now).WithMessage("Araç kiralama tarihi bugünden sonraki bir tarih olamaz!");
            RuleFor(r => r.ReturnDate).GreaterThanOrEqualTo(r => r.RentDate).WithMessage("Araç teslim tarihi kiralama tarihinden önce olamaz!");
        }
    }
}

using EntityLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CityValidation :AbstractValidator<City>
    {
        public CityValidation()
        {
            RuleFor(x => x.CityName).NotEmpty().WithMessage("Ad boş bırakılamaz");
            RuleFor(x => x.CityName).MinimumLength(3).MaximumLength(20).WithMessage("Minumum 3 maksimum 20 karakter giriniz");
        }
    }
}

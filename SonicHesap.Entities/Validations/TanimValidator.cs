using FluentValidation;
using SonicHesap.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonicHesap.Entities.Validations
{
    public class TanimValidator:AbstractValidator<Tanim>
    {
        public TanimValidator()
        {
            RuleFor(x => x.Turu).NotEmpty().WithMessage("Tanım Türü Kodu Alanı Boş Geçilemez!");
            RuleFor(x => x.Tanimi).NotEmpty().WithMessage("Tanım Alanı Boş Geçilemez!");
        }
    }
}

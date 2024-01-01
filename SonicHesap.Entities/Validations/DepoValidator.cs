using FluentValidation;
using SonicHesap.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonicHesap.Entities.Validations
{
    public class DepoValidator:AbstractValidator<Depo>
    {
        public DepoValidator()
        {
            RuleFor(x => x.DepoKodu).NotEmpty().WithMessage("Depo Kodu Alanı Boş Geçilemez!");
            RuleFor(x => x.DepoAdi).NotEmpty().WithMessage("Depo Adı Alanı Boş Geçilemez!");

        }
    }
}

using FluentValidation;
using SonicHesap.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonicHesap.Entities.Validations
{
    public class KasaValidator:AbstractValidator<Kasa>
    {
        public KasaValidator()
        {
            RuleFor(x => x.KasaKodu).NotEmpty().WithMessage("Kasa Kodu Alanı Boş Geçilemez!");
            RuleFor(x => x.KasaAdi).NotEmpty().WithMessage("Kasa Adı Alanı Boş Geçilemez!");
        }
    }
}

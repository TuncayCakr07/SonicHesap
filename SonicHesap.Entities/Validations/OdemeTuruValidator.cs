using FluentValidation;
using SonicHesap.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonicHesap.Entities.Validations
{
    public class OdemeTuruValidator:AbstractValidator<OdemeTuru>
    {
        public OdemeTuruValidator()
        {
            RuleFor(x => x.OdemeTuruKodu).NotEmpty().WithMessage("Ödeme Türü Kodu Alanı Boş Geçilemez!");
            RuleFor(x => x.OdemeTuruAdi).NotEmpty().WithMessage("Ödeme Türü Adı Alanı Boş Geçilemez!");
        }
    }
}

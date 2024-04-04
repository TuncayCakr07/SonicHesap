using FluentValidation;
using SonicHesap.Entities.Context;
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
            RuleFor(x => x.DepoAdi).Must(IsUnique).WithMessage("Bu Depo Kodu Daha Önce Eklenmiştir.Lütfen Düzenleme Yapınız!");
        }

        private bool IsUnique(string arg)
        {
            using (var context=new SonicHesapContext())
            {
                return context.Depolar.Count(c => c.DepoKodu == arg) == 0;
            }
        }
    }
}

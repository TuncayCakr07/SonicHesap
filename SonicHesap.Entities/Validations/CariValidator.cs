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
    public class CariValidator:AbstractValidator<Cari>
    {
        public CariValidator()
        {
            RuleFor(x => x.CariKodu).NotEmpty().WithMessage("Cari Kodu Alanı Boş Geçilemez!");
            RuleFor(x => x.CariAdi).NotEmpty().WithMessage("Cari Adı Alanı Boş Geçilemez!");
            RuleFor(x => x.YetkiliKisi).NotEmpty().WithMessage("Yetkili Kişi Alanı Boş Geçilemez!");
            RuleFor(x => x.FaturaUnvani).NotEmpty().WithMessage("Fatura Ünvanı Alanı Boş Geçilemez!");
            RuleFor(x => x.EMail).EmailAddress().WithMessage("Girdiğiniz E-Mail Adresi Geçersizdir!");
            RuleFor(x => x.IskontoOranı).GreaterThanOrEqualTo(0).WithMessage("İskonto Oranı Alanı 0'dan Küçük Olamaz!");
            RuleFor(x => x.RiskLimiti).GreaterThanOrEqualTo(0).WithMessage("Risk Limiti Alanı 0'dan Küçük Olamaz!");
        }
        private bool IsUnique(string arg)
        {
            using (var context = new SonicHesapContext())
            {
                return context.Cariler.Count(c => c.CariKodu == arg) == 0;
            }
        }
    }
}

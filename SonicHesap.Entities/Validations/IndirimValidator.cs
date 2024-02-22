using FluentValidation;
using SonicHesap.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonicHesap.Entities.Validations
{
    public class IndirimValidator:AbstractValidator<Indirim>
    {
        public IndirimValidator()
        {
            RuleFor(x => x.Durumu).NotNull().WithMessage("Durum boş olamaz.");
            RuleFor(x => x.StokKodu).NotEmpty().WithMessage("Stok Kodu boş olamaz.");
            RuleFor(x => x.Barkod).NotEmpty().WithMessage("Barkod boş olamaz.");
            RuleFor(x => x.StokAdi).NotEmpty().WithMessage("Stok Adı boş olamaz.");
            RuleFor(x => x.BaslangicTarihi).LessThanOrEqualTo(x => x.BitisTarihi).WithMessage("Başlangıç Tarihi, Bitiş Tarihinden büyük olamaz.");
            RuleFor(x => x.IndirimOrani).InclusiveBetween(0, 100).WithMessage("Indirim Oranı 0 ile 100 arasında olmalıdır.");
        }
    }
}

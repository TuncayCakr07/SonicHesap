using FluentValidation;
using SonicHesap.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonicHesap.Entities.Validations
{
    public class StokValidator:AbstractValidator<Stok>
    {
        public StokValidator()
        {
            RuleFor(x => x.StokKodu).NotEmpty().WithMessage("Stok Kodu Alanı Boş Geçilemez!");
            RuleFor(x => x.StokAdi).NotEmpty().WithMessage("Stok Adı Alanı Boş Geçilemez!").Length(5, 50).WithMessage("Stok Adı Alanı 5 ile 50 Karakter Arasında Olmalıdır!");
            RuleFor(x => x.Barkod).NotEmpty().WithMessage("Barkod Alanı Boş Geçilemez!");
            RuleFor(x => x.AlisFiyati1).GreaterThanOrEqualTo(0).WithMessage("Alış Fiyatı-1 Alanı 0'dan Küçük Olamaz!");
            RuleFor(x => x.AlisFiyati2).GreaterThanOrEqualTo(0).WithMessage("Alış Fiyatı-2 Alanı 0'dan Küçük Olamaz!");
            RuleFor(x => x.AlisFiyati3).GreaterThanOrEqualTo(0).WithMessage("Alış Fiyatı-3 Alanı 0'dan Küçük Olamaz!");
            RuleFor(x => x.SatisFiyati1).GreaterThanOrEqualTo(0).WithMessage("Satış Fiyatı-1 Alanı 0'dan Küçük Olamaz!");
            RuleFor(x => x.SatisFiyati2).GreaterThanOrEqualTo(0).WithMessage("Satış Fiyatı-2 Alanı 0'dan Küçük Olamaz!");
            RuleFor(x => x.SatisFiyati3).GreaterThanOrEqualTo(0).WithMessage("Satış Fiyatı-3 Alanı 0'dan Küçük Olamaz!");
        }
    }
}

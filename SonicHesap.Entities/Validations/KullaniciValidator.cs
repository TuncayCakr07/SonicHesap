using FluentValidation;
using SonicHesap.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonicHesap.Entities.Validations
{
    public class KullaniciValidator:AbstractValidator<Kullanici>
    {
        public KullaniciValidator()
        {
            RuleFor(c => c.KullaniciAdi).NotEmpty().WithMessage("Kullanıcı Adı Alanı Boş Geçilemez!");
            RuleFor(c => c.Adi).NotEmpty().WithMessage("Adı Alanı Boş Geçilemez!");
            RuleFor(c => c.Soyadi).NotEmpty().WithMessage("Soyadı Alanı Boş Geçilemez!");
            RuleFor(c => c.Gorevi).NotEmpty().WithMessage("Görevi Alanı Boş Geçilemez!");
            RuleFor(c => c.Parola).NotEmpty().WithMessage("Parola Alanı Boş Geçilemez!");
            RuleFor(c => c.HatirlatmaSorusu).NotEmpty().WithMessage("Hatırlatma Sorusu Alanı Boş Geçilemez!");
            RuleFor(c => c.Cevap).NotEmpty().WithMessage("Cevap Alanı Boş Geçilemez!");
        }
    }
}

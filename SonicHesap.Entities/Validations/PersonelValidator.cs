using FluentValidation;
using SonicHesap.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonicHesap.Entities.Validations
{
    public class PersonelValidator:AbstractValidator<Personel>
    {
        public PersonelValidator()
        {
            RuleFor(x => x.PersonelKodu).NotEmpty().WithMessage("Personel Kodu Alanı Boş Geçilemez!");
            RuleFor(x => x.PersonelAdi).NotEmpty().WithMessage("Personel Adı Alanı Boş Geçilemez!");
            RuleFor(x => x.Unvani).NotEmpty().WithMessage("Ünvanı Alanı Boş Geçilemez!");
            RuleFor(x => x.TcKimlikNo).NotEmpty().WithMessage("TC Kimlik No Alanı Boş Geçilemez!");
            RuleFor(x => x.EMail).EmailAddress().WithMessage("Girdiğiniz E-Mail Adresi Geçersizdir!");
            RuleFor(x => x.PrimOrani).GreaterThanOrEqualTo(0).WithMessage("Prim Oranı Alanı 0'dan Küçük Olamaz!");
            RuleFor(x => x.AylikMaasi).GreaterThanOrEqualTo(0).WithMessage("Aylık Maaşı Alanı 0'dan Küçük Olamaz!");
            RuleFor(x => x.CepTelefonu).NotEmpty().WithMessage("Cep Telefonu Alanı Boş Geçilemez!");
        }
    }
}

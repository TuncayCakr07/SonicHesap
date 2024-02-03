using SonicHesap.Entities.Context;
using SonicHesap.Entities.Repositories;
using SonicHesap.Entities.Tables;
using SonicHesap.Entities.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonicHesap.Entities.Data_Access
{

    public class PersonelDAL : EntityRepositoryBase<SonicHesapContext, Personel, PersonelValidator>
    {
        public object PersonelListele(SonicHesapContext context)
        {
            var result = context.Personeller.GroupJoin(context.fisler, c => c.PersonelKodu, c => c.PlasiyerKodu, (personel, fis) => new
            {
                personel.Id,
                personel.Calisiyor,
                personel.PersonelKodu,
                personel.PersonelAdi,
                personel.Unvani,
                personel.TcKimlikNo,
                personel.IseGirisTarihi,
                personel.IstenCikisTarihi,
                personel.VergiDairesi,
                personel.VergiNo,
                personel.CepTelefonu,
                personel.Telefon,
                personel.Fax,
                personel.Il,
                personel.Ilce,
                personel.Semt,
                personel.Adres,
                personel.EMail,
                personel.Web,
                personel.PrimOrani,
                personel.AylikMaasi,
                personel.Aciklama,
                ToplamSatis=fis.Where(c=>c.FisTuru=="Perakende Satış Faturası").Sum(c=>c.ToplamTutar) ?? 0,
                PrimTutari=(fis.Where(c => c.FisTuru == "Perakende Satış Faturası").Sum(c => c.ToplamTutar) ?? 0)/100*personel.PrimOrani,
            }).ToList();
            return result;
        }
    }
}

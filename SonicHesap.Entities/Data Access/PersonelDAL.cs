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
            var result = context.Personeller.GroupJoin(context.fisler, c => c.Id, c => c.PlasiyerId, (personel, fis) => new
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
                ToplamSatis=fis.Where(c=>c.FisTuru=="Perakende Satış Faturası" || c.FisTuru=="Toptan Satış Faturası").Sum(c=>c.ToplamTutar) ?? 0,
                PrimTutari=(fis.Where(c => c.FisTuru == "Perakende Satış Faturası" || c.FisTuru == "Toptan Satış Faturası").Sum(c => c.ToplamTutar) ?? 0)/100*personel.PrimOrani,
            }).ToList();
            return result;
        }

        public object TarihePersonelListele(SonicHesapContext context,int Ay,int Yil)
        {
            var result = context.Personeller.GroupJoin(context.fisler, c => c.Id, c => c.PlasiyerId, (personel, fis) => new
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
                ToplamSatis = fis.Where(c => c.FisTuru == "Perakende Satış Faturası" || c.FisTuru == "Toptan Satış Faturası" && c.Tarih.Month==Ay && c.Tarih.Year==Yil).Sum(c => c.ToplamTutar) ?? 0,
                PrimTutari = (fis.Where(c => c.FisTuru == "Perakende Satış Faturası" || c.FisTuru == "Toptan Satış Faturası" && c.Tarih.Month == Ay && c.Tarih.Year == Yil).Sum(c => c.ToplamTutar) ?? 0) / 100 * personel.PrimOrani,
            }).ToList();
            return result;
        }

        public object PersonelFisToplam(SonicHesapContext context,int personelId)
        {
            var result = (from c in context.fisler.Where(c => c.PlasiyerId == personelId)
                          group c by new { c.FisTuru } into grp
                          select new
                          {
                              Bilgi = grp.Key.FisTuru,
                              KayitSayisi = grp.Count(),
                              ToplamTutar = grp.Sum(c => c.ToplamTutar)
                          }).ToList(); 
            return result;
        }
        
    }
}

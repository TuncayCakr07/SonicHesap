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
    public class KasaDAL : EntityRepositoryBase<SonicHesapContext, Kasa,KasaValidator>
    {
        public object KasaListele(SonicHesapContext context)
        {
            var result = context.Kasalar.GroupJoin(context.KasaHareketleri, c => c.KasaKodu, c => c.KasaKodu, (kasa, kasahareket) => new
            {
                kasa.Id,
                kasa.KasaKodu,
                kasa.KasaAdi,
                kasa.YetkiliKodu,
                kasa.YetkiliAdi,
                kasa.Aciklama,
                KasaGiris=(kasahareket.Where(c=>c.KasaKodu==kasa.KasaKodu && c.Hareket=="Kasa Giriş").Sum(c=>c.Tutar)?? 0),
                KasaCikis=(kasahareket.Where(c=>c.KasaKodu==kasa.KasaKodu && c.Hareket=="Kasa Çıkış").Sum(c=>c.Tutar)?? 0),
                Bakiye= (kasahareket.Where(c => c.KasaKodu == kasa.KasaKodu && c.Hareket == "Kasa Giriş").Sum(c => c.Tutar) ?? 0) - (kasahareket.Where(c => c.KasaKodu == kasa.KasaKodu && c.Hareket == "Kasa Çıkış").Sum(c => c.Tutar) ?? 0)
            }).ToList();
            return result;
        }
    }
}

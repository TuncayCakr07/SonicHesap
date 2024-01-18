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
    public class DepoDAL : EntityRepositoryBase<SonicHesapContext, Depo,DepoValidator>
    {
        public object DepoBazindaStokListele(SonicHesapContext context,string stokKodu)
        {
            var result = context.Depolar.GroupJoin(context.StokHareketleri.Where(c => c.StokKodu == stokKodu),
                c => c.DepoKodu,
                c => c.DepoKodu,
                (depolar, stokhareketleri) => new
                {
                    depolar.Id,
                    depolar.DepoKodu,
                    depolar.DepoAdi,
                    depolar.YetkiliKodu,
                    depolar.YetkiliAdi,
                    depolar.Telefon,
                    depolar.Il,
                    depolar.Ilce,
                    depolar.Semt,
                    depolar.Adres,
                    StokGiris = stokhareketleri.Where(c => c.Hareket == "Stok Giriş").Sum(c => c.Miktar) ?? 0,
                    StokCikis = stokhareketleri.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0,
                    MevcutStok = (stokhareketleri.Where(c => c.Hareket == "Stok Giriş").Sum(c => c.Miktar) ?? 0) -
                                 (stokhareketleri.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0),
                }).ToList();
            return result;
        }
    }
}

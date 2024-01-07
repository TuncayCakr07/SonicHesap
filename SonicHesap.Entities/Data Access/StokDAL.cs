using SonicHesap.Entities.Context;
using SonicHesap.Entities.Repositories;
using SonicHesap.Entities.Tables;
using SonicHesap.Entities.Validations;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SonicHesap.Entities.Data_Access
{
    public class StokDAL:EntityRepositoryBase<SonicHesapContext,Stok,StokValidator>
    {
        public object GetAllJoin(SonicHesapContext context)
        {
            var table = context.Stoklar.GroupJoin(
                context.StokHareketleri,
                stok => stok.StokKodu,
                hareket => hareket.StokKodu,
                (stok, hareketler) => new
                {
                    stok.Id,
                    stok.Durumu,
                    stok.StokKodu,
                    stok.StokAdi,
                    stok.Barkod,
                    stok.BarkodTuru,
                    stok.Birimi,
                    stok.StokGrubu,
                    stok.StokAltGrubu,
                    stok.Marka,
                    stok.Modeli,
                    stok.OzelKod1,
                    stok.OzelKod2,
                    stok.OzelKod3,
                    stok.OzelKod4,
                    stok.GarantiSuresi,
                    stok.UreticiKodu,
                    stok.AlisKdv,
                    stok.SatisKdv,
                    stok.AlisFiyati1,
                    stok.AlisFiyati2,
                    stok.AlisFiyati3,
                    stok.SatisFiyati1,
                    stok.SatisFiyati2,
                    stok.SatisFiyati3,
                    stok.MinStokMiktari,
                    stok.MaxStokMiktari,
                    stok.Aciklama,
                    StokGiris = hareketler.Where(c => c.Hareket == "Stok Giriş").Sum(c => c.Miktar) ?? 0,
                    StokCikis = hareketler.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0,
                    MevcutStok = (hareketler.Where(c => c.Hareket == "Stok Giriş").Sum(c => c.Miktar) ?? 0) -
                                 (hareketler.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0),
                }).ToList();

            return table;
        }

        public object GetGenelStok(SonicHesapContext context,string stokKodu)
        {
            var result = (from c in context.StokHareketleri
                          group c by new { c.Hareket } into g
                          select new
                          {
                              Bilgi = g.Key.Hareket,
                              KayitSayisi = g.Count(),
                              Toplam = g.Sum(c => c.Miktar)
                          }).ToList();
            return result;
        }

        public object GetDepoStok(SonicHesapContext context, string stokKodu)
        {
            var result = context.Depolar.GroupJoin(context.StokHareketleri.Where(c => c.StokKodu == stokKodu),
               c => c.DepoKodu,
               c => c.DepoKodu,
               (depolar, stokhareketleri) => new
               {
                   depolar.DepoKodu,
                   depolar.DepoAdi,
                   StokGiris = stokhareketleri.Where(c => c.Hareket == "Stok Giriş").Sum(c => c.Miktar) ?? 0,
                   StokCikis = stokhareketleri.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0,
                   MevcutStok = (stokhareketleri.Where(c => c.Hareket == "Stok Giriş").Sum(c => c.Miktar) ?? 0) -
                                (stokhareketleri.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0),
               }).ToList();
            return result;
        }
    }
}

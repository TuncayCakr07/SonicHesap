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
    public class StokHareketDAL : EntityRepositoryBase<SonicHesapContext, StokHareket,StokHareketValidator>
    {

        public object GetGenelStok(SonicHesapContext context, int stokId)
        {
            var result = (from c in context.StokHareketleri.Where(c => c.Siparis == false && c.Id == stokId)
                          group c by new { c.Hareket } into g
                          select new
                          {
                              Bilgi = g.Key.Hareket,
                              KayitSayisi = g.Count(),
                              Toplam = g.Sum(c => c.Miktar)
                          }).ToList();
            return result;
        }

        public object GetDepoStok(SonicHesapContext context, int stokId)
        {
            var result = context.Depolar.GroupJoin(context.StokHareketleri.Where(c => c.Siparis == false && c.StokId == stokId),
               c => c.Id,
               c => c.DepoId,
               (depolar, stokhareketleri) => new
               {
                   depolar.DepoKodu,
                   depolar.DepoAdi,
                   StokGiris = stokhareketleri.Where(c => c.Siparis == false && c.Hareket == "Stok Giriş").Sum(c => c.Miktar) ?? 0,
                   StokCikis = stokhareketleri.Where(c => c.Siparis == false && c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0,
                   MevcutStok = (stokhareketleri.Where(c => c.Siparis == false && c.Hareket == "Stok Giriş").Sum(c => c.Miktar) ?? 0) -
                                (stokhareketleri.Where(c => c.Siparis == false && c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0),
               }).ToList();
            return result;
        }
        public object DepoStokListele(SonicHesapContext context, int depoId)
        {
            var table = context.Stoklar.GroupJoin(context.StokHareketleri.Where(c=>c.Siparis==false && c.DepoId== depoId),
                stok => stok.Id,
                hareket => hareket.StokId,
                (stok, hareketler) => new
                {
                    stok.StokAdi,
                    stok.Barkod,
                    StokGiris = hareketler.Where(c => c.Siparis == false && c.Hareket == "Stok Giriş").Sum(c => c.Miktar) ?? 0,
                    StokCikis = hareketler.Where(c => c.Siparis == false && c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0,
                    MevcutStok = (hareketler.Where(c => c.Siparis == false && c.Hareket == "Stok Giriş").Sum(c => c.Miktar) ?? 0) -
                                 (hareketler.Where(c => c.Siparis == false && c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0),
                }).ToList();

            return table;
        }
        public object DepoIstatistikListele(SonicHesapContext context, int depoId)
        {

            List<GenelToplam> genelToplamlar = new List<GenelToplam>()
            {
                new GenelToplam
                {
                    Bilgi="Stok Giriş",
                    KayitSayisi=context.StokHareketleri.Where(c=>c.Siparis==false && c.DepoId==depoId && c.Hareket=="Stok Giriş").Count(),
                    Tutar=context.StokHareketleri.Where(c=>c.Siparis==false && c.DepoId==depoId && c.Hareket=="Stok Giriş").Sum(c=>c.Miktar) ?? 0,

                },
                new GenelToplam
                {
                    Bilgi="Stok Çıkış",
                   KayitSayisi=context.StokHareketleri.Where(c=>c.Siparis==false && c.DepoId==depoId && c.Hareket=="Stok Çıkış").Count(),
                    Tutar=context.StokHareketleri.Where(c=>c.Siparis==false && c.DepoId==depoId&& c.Hareket=="Stok Çıkış").Sum(c=>c.Miktar) ?? 0,
                },
            };
            return genelToplamlar;
        }
    }
}

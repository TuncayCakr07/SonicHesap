using SonicHesap.Entities.Context;
using SonicHesap.Entities.Repositories;
using SonicHesap.Entities.Tables;
using SonicHesap.Entities.Tables.OtherTables;
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
    public class StokDAL : EntityRepositoryBase<SonicHesapContext, Stok, StokValidator>
    {
        public object StokListele(SonicHesapContext context)
        {
            var table = context.Stoklar.GroupJoin(context.StokHareketleri, c => c.Id, c => c.StokId,
                (Stoklar, StokHareketleri) =>

                new
                {
                    Stoklar.Id,
                    Stoklar.Durumu,
                    Stoklar.StokKodu,
                    Stoklar.StokAdi,
                    Stoklar.Barkod,
                    Stoklar.BarkodTuru,
                    Stoklar.Birimi,
                    Stoklar.StokGrubu,
                    Stoklar.StokAltGrubu,
                    Stoklar.Marka,
                    Stoklar.Modeli,
                    Stoklar.OzelKod1,
                    Stoklar.OzelKod2,
                    Stoklar.OzelKod3,
                    Stoklar.OzelKod4,
                    Stoklar.GarantiSuresi,
                    Stoklar.UreticiKodu,
                    Stoklar.AlisKdv,
                    Stoklar.SatisKdv,
                    Stoklar.AlisFiyati1,
                    Stoklar.AlisFiyati2,
                    Stoklar.AlisFiyati3,
                    Stoklar.SatisFiyati1,
                    Stoklar.SatisFiyati2,
                    Stoklar.SatisFiyati3,
                    Stoklar.MinStokMiktari,
                    Stoklar.MaxStokMiktari,
                    Stoklar.Aciklama,
                    StokGiris = StokHareketleri.Where(c => c.Siparis == false && c.Hareket == "Stok Giriş").Sum(c => c.Miktar) ?? 0,
                    StokCikis = StokHareketleri.Where(c => c.Siparis == false && c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0,
                    MevcutStok = (StokHareketleri.Where(c => c.Siparis == false && c.Hareket == "Stok Giriş").Sum(c => c.Miktar) ?? 0) -
                                 (StokHareketleri.Where(c => c.Siparis == false && c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0),
                }).ToList();
            return table;
        }
        public StokBakiye StokBakiyesi(SonicHesapContext context, int stokId)
        {
            return new StokBakiye
            {
                StokId = stokId,
                StokGiris = context.StokHareketleri.Where(c => c.Siparis == false && c.Hareket == "Stok Giriş").Sum(c => c.Miktar) ?? 0,
                StokCikis = context.StokHareketleri.Where(c => c.Siparis == false && c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0,
                MevcutStok= (context.StokHareketleri.Where(c => c.Siparis == false && c.Hareket == "Stok Giriş").Sum(c => c.Miktar) ?? 0) -
                                 (context.StokHareketleri.Where(c => c.Siparis == false && c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0),
            };
        }
    }
}

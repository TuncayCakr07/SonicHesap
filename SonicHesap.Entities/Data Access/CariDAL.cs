using SonicHesap.Entities.Context;
using SonicHesap.Entities.Interfaces;
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
    public class CariDAL : EntityRepositoryBase<SonicHesapContext, Cari, CariValidator>
    {
        public object CariListele(SonicHesapContext context)
        {
            var result = context.Cariler.GroupJoin(context.fisler, c => c.Id, c => c.CariId, (cariler, fisler) => new
            {
                cariler.Id,
                cariler.Durumu,
                cariler.CariKodu,
                cariler.CariAdi,
                cariler.CariTuru,
                cariler.YetkiliKisi,
                cariler.FaturaUnvani,
                cariler.CepTelefonu,
                cariler.Telefon,
                cariler.Fax,
                cariler.EMail,
                cariler.Web,
                cariler.Il,
                cariler.Ilce,
                cariler.Semt,
                cariler.Adres,
                cariler.CariGrubu,
                cariler.CariAltGrubu,
                cariler.OzelKod1,
                cariler.OzelKod2,
                cariler.OzelKod3,
                cariler.OzelKod4,
                cariler.VergiDairesi,
                cariler.VergiNo,
                cariler.IskontoOranı,
                cariler.RiskLimiti,
                cariler.AlisOzelFiyati,
                cariler.SatisOzelFiyati,
                cariler.Aciklama,
                Alacak = fisler.Sum(c => c.Alacak) ?? 0,
                Borç = fisler.Sum(c => c.Borc) ?? 0,
                Bakiye = fisler.Select(c => (decimal?)(c.Alacak ?? 0 - c.Borc ?? 0)).Sum() ?? 0
            }).ToList();
            return result;
        }

        public object CariFisAyrinti(SonicHesapContext context,int cariId)
        {
            return (from fis in context.fisler.Where(c => c.CariId == cariId)
                    select new
                    {
                        fis.Id,
                        fis.FisKodu,
                        fis.FisTuru,
                        fis.BelgeNo,
                        fis.Tarih,
                        fis.Aciklama,
                        fis.Alacak,
                        fis.Borc,
                        Bakiye = context.fisler.OrderBy(c => c.Tarih).ThenBy(c=>c.Id).Where(c => c.CariId == cariId && c.Tarih <= fis.Tarih && c.Id<=fis.Id).Select(c => (decimal?)(c.Alacak ?? 0 - c.Borc ?? 0)).Sum() ?? 0
                    }).OrderBy(c => c.Tarih).ToList();
        }
        public object CariFisGenelToplam(SonicHesapContext context, int cariId)
        {
            var result=(from c in context.fisler.Where(c=>c.CariId==cariId) group c by new {c.FisTuru} into grp select new
            {
              Bilgi=grp.Key.FisTuru,
              KayitSayisi=grp.Count(),
              Tutar=grp.Sum(c=>c.Alacak??c.Borc),
            }).ToList();
            return result;
        }
        public object CariGenelToplam(SonicHesapContext context, int cariId)
        {
            decimal alacak = context.fisler.Where(c => c.CariId == cariId).Sum(c => c.Alacak) ?? 0;
            decimal borc = context.fisler.Where(c => c.CariId == cariId).Sum(c => c.Borc) ?? 0;
            List<GenelToplam> genelToplamlar = new List<GenelToplam>()
            {
                new GenelToplam
                {
                    Bilgi="Alacak",
                    Tutar=alacak,

                },
                new GenelToplam
                {
                    Bilgi="Borç",
                    Tutar=borc,

                },
                new GenelToplam
                {
                    Bilgi="Bakiye",
                    Tutar=alacak-borc,

                }
            };
            return genelToplamlar;
        }
        public CariBakiye CariBakiyesi(SonicHesapContext context, int cariId)
        {
            decimal alacak = context.fisler.Where(c => c.CariId == cariId).Sum(c => c.Alacak) ?? 0;
            decimal borc = context.fisler.Where(c => c.CariId == cariId).Sum(c => c.Borc) ?? 0;
            CariBakiye entity = new CariBakiye
            {
                CariId = cariId,
                RiskLimiti=Convert.ToDecimal(context.Cariler.SingleOrDefault(c=>c.Id==cariId).RiskLimiti),
                Alacak = alacak,
                Borc = borc,
                Bakiye=alacak-borc,
            };
            return entity;
        }
    }
}

using SonicHesap.Entities.Context;
using SonicHesap.Entities.Repositories;
using SonicHesap.Entities.Tables;
using SonicHesap.Entities.Validations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonicHesap.Entities.Data_Access
{
    public class HizliSatisDAL : EntityRepositoryBase<SonicHesapContext, HizliSatis, HizliSatisValidator>
    {
        public void AddOrUpdate(HizliSatis hizliSatis)
        {
            using (var context = new SonicHesapContext())
            {
                var existingItem = context.HizliSatislar.FirstOrDefault(c => c.Barkod == hizliSatis.Barkod);
                if (existingItem != null)
                {
                    // Eğer ürün varsa güncelle
                    existingItem.UrunAdi = hizliSatis.UrunAdi;
                    existingItem.GrupId = hizliSatis.GrupId;
                    // Diğer özellikleri de güncelle...

                    context.Entry(existingItem).State = EntityState.Modified;
                }
                else
                {
                    // Eğer ürün yoksa ekle
                    context.HizliSatislar.Add(hizliSatis);
                }

                context.SaveChanges();
            }
        }
    }
}

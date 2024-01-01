using SonicHesap.Entities.Context;
using SonicHesap.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SonicHesap.Entities.Data_Access
{
    public class StokDAL
    {
        public void AddOrUpdate(SonicHesapContext context,Stok entity)
        {
            context.Stoklar.AddOrUpdate(entity);
        }

        public void Delete(SonicHesapContext context,Expression<Func<Stok,bool>> filter)
        {
            context.Stoklar.RemoveRange(context.Stoklar.Where(filter));
        }

        public void Save(SonicHesapContext context)
        {
            context.SaveChanges();
        }
    }
}

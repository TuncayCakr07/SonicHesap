using SonicHesap.Entities.Context;
using SonicHesap.Entities.Interfaces;
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
    public class CariDAL : IEntityRepository<SonicHesapContext, Cari>
    {
        public void AddOrUpdate(SonicHesapContext context, Cari entity)
        {
            context.Cariler.AddOrUpdate(entity);
        }

        public void Delete(SonicHesapContext context, Expression<Func<Cari, bool>> filter)
        {
            context.Cariler.RemoveRange(context.Cariler.Where(filter));
        }

        public void Save(SonicHesapContext context)
        {
            context.SaveChanges();
        }
    }
}

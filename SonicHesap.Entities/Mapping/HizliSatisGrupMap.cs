using SonicHesap.Entities.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonicHesap.Entities.Mapping
{
    public class HizliSatisGrupMap:EntityTypeConfiguration<HizliSatisGrup>
    {
        public HizliSatisGrupMap()
        {
            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(x => x.GrupAdi).HasMaxLength(30);
            this.Property(x => x.Aciklama).HasMaxLength(30);

            this.ToTable("HizliSatisGruplari");
            this.Property(x => x.Id).HasColumnName("Id");
            this.Property(x => x.GrupAdi).HasColumnName("GrupAdi");
            this.Property(x => x.Aciklama).HasColumnName("Aciklama");
        }
    }
}

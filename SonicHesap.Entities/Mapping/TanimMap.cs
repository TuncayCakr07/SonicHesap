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
    public class TanimMap:EntityTypeConfiguration<Tanim>
    {
        public TanimMap()
        {
            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(x=>x.Turu).HasMaxLength(15);
            this.Property(x=>x.Tanimi).HasMaxLength(30);
            this.Property(x=>x.Aciklama).HasMaxLength(200);

            this.ToTable("Tanimlar");
            this.Property(x => x.Id).HasColumnName("Id");
            this.Property(x => x.Turu).HasColumnName("Turu");
            this.Property(x => x.Tanimi).HasColumnName("Tanimi");
            this.Property(x => x.Aciklama).HasColumnName("Aciklama");
        }
    }
}

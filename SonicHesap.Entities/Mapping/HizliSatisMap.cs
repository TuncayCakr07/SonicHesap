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
    public class HizliSatisMap:EntityTypeConfiguration<HizliSatis>
    {
        public HizliSatisMap()
        {
            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(x => x.Barkod).HasMaxLength(20);
            this.Property(x => x.UrunAdi).HasMaxLength(50);

            this.ToTable("HizliSatislar");
            this.Property(x => x.Id).HasColumnName("Id");
            this.Property(x => x.Barkod).HasColumnName("Barkod");
            this.Property(x => x.UrunAdi).HasColumnName("UrunAdi");
        }
    }
}

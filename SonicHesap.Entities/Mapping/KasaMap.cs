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
    public class KasaMap:EntityTypeConfiguration<Kasa>
    {
        public KasaMap()
        {
            this.HasKey(c => c.Id);
            this.Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(x => x.KasaKodu).HasMaxLength(15);
            this.Property(x => x.KasaAdi).HasMaxLength(30);
            this.Property(x => x.YetkiliKodu).HasMaxLength(15);
            this.Property(x => x.YetkiliAdi).HasMaxLength(50);
            this.Property(c => c.Aciklama).HasMaxLength(200);

            this.ToTable("Kasalar");
            this.Property(x => x.Id).HasColumnName("Id");
            this.Property(x => x.KasaKodu).HasColumnName("KasaKodu");
            this.Property(x => x.KasaAdi).HasColumnName("KasaAdi");
            this.Property(x => x.YetkiliKodu).HasColumnName("YetkiliKodu");
            this.Property(x => x.YetkiliAdi).HasColumnName("YetkiliAdi");
            this.Property(c => c.Aciklama).HasColumnName("Aciklama");
        }
    }
}

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
    public class DepoMap:EntityTypeConfiguration<Depo>
    {
        public DepoMap()
        {
            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(x => x.DepoKodu).HasMaxLength(15);
            this.Property(x => x.DepoAdi).HasMaxLength(30);
            this.Property(x => x.YetkiliKodu).HasMaxLength(15);
            this.Property(x => x.YetkiliAdi).HasMaxLength(50);
            this.Property(c => c.Il).HasMaxLength(50);
            this.Property(c => c.Ilce).HasMaxLength(50);
            this.Property(c => c.Semt).HasMaxLength(50);
            this.Property(c => c.Adres).HasMaxLength(200);
            this.Property(c => c.Telefon).HasMaxLength(50);
            this.Property(c => c.Aciklama).HasMaxLength(200);

            this.ToTable("Depolar");
            this.Property(x => x.Id).HasColumnName("Id");
            this.Property(x => x.DepoKodu).HasColumnName("DepoKodu");
            this.Property(x => x.DepoAdi).HasColumnName("DepoAdi");
            this.Property(x => x.YetkiliKodu).HasColumnName("YetkiliKodu");
            this.Property(x => x.YetkiliAdi).HasColumnName("YetkiliAdi");
            this.Property(c => c.Il).HasColumnName("Il");
            this.Property(c => c.Ilce).HasColumnName("Ilce");
            this.Property(c => c.Semt).HasColumnName("Semt");
            this.Property(c => c.Adres).HasColumnName("Adres");
            this.Property(c => c.Telefon).HasColumnName("Telefon");
            this.Property(c => c.Aciklama).HasColumnName("Aciklama");
        }
    }
}

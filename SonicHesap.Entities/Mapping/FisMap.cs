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
    public class FisMap:EntityTypeConfiguration<Fis>
    {
        public FisMap()
        {
            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(x => x.FisKodu).HasMaxLength(15);
            this.Property(x => x.FisTuru).HasMaxLength(30);
            this.Property(x => x.CariKodu).HasMaxLength(15);
            this.Property(x => x.CariAdi).HasMaxLength(50);
            this.Property(x => x.BelgeNo).HasMaxLength(30);
            this.Property(x => x.PlasiyerKodu).HasMaxLength(15);
            this.Property(x => x.PlasiyerAdi).HasMaxLength(50);
            this.Property(x => x.IskontoOrani).HasPrecision(5, 2);
            this.Property(x => x.IskontoTutar).HasPrecision(12, 2);
            this.Property(x => x.ToplamTutar).HasPrecision(12, 2);
            this.Property(x=>x.Aciklama).HasMaxLength(300);

            this.ToTable("Fisler");
            this.Property(x => x.Id).HasColumnName("Id");
            this.Property(x => x.FisKodu).HasColumnName("FisKodu");
            this.Property(x => x.FisTuru).HasColumnName("FisTuru");
            this.Property(x => x.CariKodu).HasColumnName("CariKodu");
            this.Property(x => x.CariAdi).HasColumnName("CariAdi");
            this.Property(x => x.BelgeNo).HasColumnName("BelgeNo");
            this.Property(x => x.Tarih).HasColumnName("Tarih");
            this.Property(x => x.PlasiyerKodu).HasColumnName("PlasiyerKodu");
            this.Property(x => x.PlasiyerAdi).HasColumnName("PlasiyerAdi");
            this.Property(x => x.IskontoOrani).HasColumnName("IskontoOrani");
            this.Property(x => x.IskontoTutar).HasColumnName("IskontoTutar");
            this.Property(x => x.ToplamTutar).HasColumnName("ToplamTutar");
            this.Property(x => x.Aciklama).HasColumnName("Aciklama");
        }
    }
}

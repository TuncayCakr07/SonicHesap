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
    public class KasaHareketMap:EntityTypeConfiguration<KasaHareket>
    {
        public KasaHareketMap()
        {
            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(x=>x.FisKodu).HasMaxLength(15);
            this.Property(x=>x.Hareket).HasMaxLength(15);
            this.Property(x=>x.KasaKodu).HasMaxLength(15);
            this.Property(x=>x.KasaAdi).HasMaxLength(30);
            this.Property(x=>x.OdemeTuruKodu).HasMaxLength(15);
            this.Property(x=>x.OdemeTuruAdi).HasMaxLength(30);
            this.Property(x => x.CariKodu).HasMaxLength(15);
            this.Property(x => x.CariAdi).HasMaxLength(50);
            this.Property(x => x.Tutar).HasPrecision(12, 2);
            this.Property(x => x.Aciklama).HasMaxLength(300);

            this.ToTable("KasaHareketleri");
            this.Property(x => x.Id).HasColumnName("Id");
            this.Property(x => x.FisKodu).HasColumnName("FisKodu");
            this.Property(x => x.Hareket).HasColumnName("Hareket");
            this.Property(x => x.KasaKodu).HasColumnName("KasaKodu");
            this.Property(x => x.KasaAdi).HasColumnName("KasaAdi");
            this.Property(x => x.OdemeTuruKodu).HasColumnName("OdemeTuruKodu");
            this.Property(x => x.OdemeTuruAdi).HasColumnName("OdemeTuruAdi");
            this.Property(x => x.CariKodu).HasColumnName("CariKodu");
            this.Property(x => x.CariAdi).HasColumnName("CariAdi");
            this.Property(x => x.Tarih).HasColumnName("Tarih");
            this.Property(x => x.Tutar).HasColumnName("Tutar"); 
            this.Property(x => x.Aciklama).HasColumnName("Aciklama");
        }
    }
}

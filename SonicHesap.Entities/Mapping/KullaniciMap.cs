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
    public class KullaniciMap:EntityTypeConfiguration<Kullanici>
    {
        public KullaniciMap()
        {
            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(x => x.KullaniciAdi).HasMaxLength(20);
            this.Property(x => x.Adi).HasMaxLength(20);
            this.Property(x => x.Soyadi).HasMaxLength(20);
            this.Property(x => x.Gorevi).HasMaxLength(20);
            this.Property(x => x.HatirlatmaSorusu).HasMaxLength(50);
            this.Property(x => x.Cevap).HasMaxLength(20);
            this.Property(x => x.Parola).HasMaxLength(32);
            
            this.ToTable("Kullanicilar");
            this.Property(x => x.Id).HasColumnName("Id");
            this.Property(x => x.KullaniciAdi).HasColumnName("KullaniciAdi");
            this.Property(x => x.Adi).HasColumnName("Adi");
            this.Property(x => x.Soyadi).HasColumnName("Soyadi");
            this.Property(x => x.Gorevi).HasColumnName("Gorevi");
            this.Property(x => x.HatirlatmaSorusu).HasColumnName("HatirlatmaSorusu");
            this.Property(x => x.Cevap).HasColumnName("Cevap");
            this.Property(x => x.Parola).HasColumnName("Parola");
            this.Property(x => x.KayitTarihi).HasColumnName("KayitTarihi");
            this.Property(x => x.SonGirisTarihi).HasColumnName("SonGirisTarihi");
        }
    }
}

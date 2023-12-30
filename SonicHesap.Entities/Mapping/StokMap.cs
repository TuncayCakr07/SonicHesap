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
    public class StokMap:EntityTypeConfiguration<Stok>
    {
        public StokMap()
        {
            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(x => x.StokKodu).HasMaxLength(12);
            this.Property(x=>x.StokAdi).HasMaxLength(50).HasColumnName("StokAdi").IsRequired();
            this.Property(x => x.Barkod).HasMaxLength(20);
            this.Property(x => x.BarkodTuru).HasMaxLength(20);
            this.Property(x => x.Birimi).HasMaxLength(20);
            this.Property(x => x.StokGrubu).HasMaxLength(30);
            this.Property(x => x.StokAltGrubu).HasMaxLength(30);
            this.Property(x => x.Marka).HasMaxLength(30);
            this.Property(x => x.Modeli).HasMaxLength(30);
            this.Property(x => x.OzelKod1).HasMaxLength(30);
            this.Property(x => x.OzelKod2).HasMaxLength(30);
            this.Property(x => x.OzelKod3).HasMaxLength(30);
            this.Property(x => x.OzelKod4).HasMaxLength(30);
            this.Property(x => x.GarantiSuresi).HasMaxLength(20);
            this.Property(x => x.UreticiKodu).HasMaxLength(20);
            this.Property(x => x.AlisFiyati1).HasPrecision(12, 2);
            this.Property(x => x.AlisFiyati2).HasPrecision(12, 2);
            this.Property(x => x.AlisFiyati3).HasPrecision(12, 2);
            this.Property(x => x.SatisFiyati1).HasPrecision(12, 2);
            this.Property(x => x.SatisFiyati2).HasPrecision(12, 2);
            this.Property(x => x.SatisFiyati3).HasPrecision(12, 2);
            this.Property(x => x.MinStokMiktarı).HasPrecision(12, 3);
            this.Property(x => x.MaxStokMiktarı).HasPrecision(12, 3);
            this.Property(x => x.Aciklama).HasMaxLength(300);

            this.ToTable("Stoklar");
            this.Property(x=>x.Id).HasColumnName("Id");
            this.Property(x=>x.Durumu).HasColumnName("Durumu");
            this.Property(x=>x.StokKodu).HasColumnName("StokKodu");
            this.Property(x=>x.StokAdi).HasColumnName("StokAdi");
            this.Property(x=>x.Barkod).HasColumnName("Barkod");
            this.Property(x=>x.BarkodTuru).HasColumnName("BarkodTuru");
            this.Property(x=>x.Birimi).HasColumnName("Birimi");
            this.Property(x=>x.StokGrubu).HasColumnName("StokGrubu");
            this.Property(x=>x.StokAltGrubu).HasColumnName("StokAltGrubu");
            this.Property(x=>x.Marka).HasColumnName("Marka");
            this.Property(x=>x.Modeli).HasColumnName("Modeli");
            this.Property(x=>x.OzelKod1).HasColumnName("OzelKod1");
            this.Property(x=>x.OzelKod2).HasColumnName("OzelKod2");
            this.Property(x=>x.OzelKod3).HasColumnName("OzelKod3");
            this.Property(x=>x.OzelKod4).HasColumnName("OzelKod4");
            this.Property(x=>x.GarantiSuresi).HasColumnName("GarantiSuresi");
            this.Property(x=>x.UreticiKodu).HasColumnName("UreticiKodu");
            this.Property(x=>x.AlisKdv).HasColumnName("AlisKdv");
            this.Property(x=>x.SatisKdv).HasColumnName("SatisKdv");
            this.Property(x=>x.AlisFiyati1).HasColumnName("AlisFiyati1");
            this.Property(x=>x.AlisFiyati2).HasColumnName("AlisFiyati2");
            this.Property(x=>x.AlisFiyati3).HasColumnName("AlisFiyati3");
            this.Property(x=>x.SatisFiyati1).HasColumnName("SatisFiyati1");
            this.Property(x=>x.SatisFiyati2).HasColumnName("SatisFiyati2");
            this.Property(x=>x.SatisFiyati3).HasColumnName("SatisFiyati3");
            this.Property(x=>x.MaxStokMiktarı).HasColumnName("MaxStokMiktarı");
            this.Property(x=>x.MinStokMiktarı).HasColumnName("MinStokMiktarı");
            this.Property(x=>x.Aciklama).HasColumnName("Aciklama");
        }
    }
}

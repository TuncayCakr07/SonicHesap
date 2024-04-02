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
    public class PersonelHareketMap:EntityTypeConfiguration<PersonelHareket>
    {
        public PersonelHareketMap()
        {
            this.HasKey(x => x.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.FisKodu).HasMaxLength(20);
            this.Property(p => p.Unvani).HasMaxLength(20);
            this.Property(p => p.PersonelKodu).HasMaxLength(20);
            this.Property(p => p.PersonelAdi).HasMaxLength(50);
            this.Property(p => p.TCKimlikNo).HasMaxLength(11);
            this.Property(p => p.PrimOrani).HasPrecision(5, 2);
            this.Property(p => p.ToplamSatis).HasPrecision(12, 2);
            this.Property(p => p.AylikMaasi).HasPrecision(12, 2);
            this.Property(p => p.Aciklama).HasMaxLength(200);

            ToTable("PersonelHareketleri");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.FisKodu).HasColumnName("FisKodu");
            this.Property(p => p.Unvani).HasColumnName("Unvani");
            this.Property(p => p.PersonelKodu).HasColumnName("PersonelKodu");
            this.Property(p => p.PersonelAdi).HasColumnName("PersonelAdi");
            this.Property(p => p.TCKimlikNo).HasColumnName("TcKimlikNo");
            this.Property(p => p.Donemi).HasColumnName("Donemi");
            this.Property(p => p.ToplamSatis).HasColumnName("ToplamSatis");
            this.Property(p => p.PrimOrani).HasColumnName("PrimOrani");
            this.Property(p => p.AylikMaasi).HasColumnName("AylikMaasi");
            this.Property(p => p.Aciklama).HasColumnName("Aciklama");
        }
    }
}

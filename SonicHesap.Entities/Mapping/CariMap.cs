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
    public class CariMap:EntityTypeConfiguration<Cari>
    {
        public CariMap()
        {
            this.HasKey(c => c.Id);
            this.Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(c=>c.CariTuru).HasMaxLength(20);
            this.Property(c=>c.CariKodu).HasMaxLength(20);
            this.Property(c=>c.CariAdi).HasMaxLength(50);
            this.Property(c=>c.YetkiliKisi).HasMaxLength(50);
            this.Property(c=>c.FaturaUnvani).HasMaxLength(50);
            this.Property(c=>c.CepTelefonu).HasMaxLength(50);
            this.Property(c=>c.Telefon).HasMaxLength(50);  
            this.Property(c=>c.Fax).HasMaxLength(50);
            this.Property(c=>c.EMail).HasMaxLength(50);
            this.Property(c=>c.Web).HasMaxLength(50);
            this.Property(c=>c.Il).HasMaxLength(50);
            this.Property(c=>c.Ilce).HasMaxLength(50);
            this.Property(c=>c.Semt).HasMaxLength(50);
            this.Property(c=>c.Adres).HasMaxLength(200);
            this.Property(c=>c.CariGrubu).HasMaxLength(50);
            this.Property(c=>c.CariAltGrubu).HasMaxLength(50);
            this.Property(c=>c.OzelKod1).HasMaxLength(50);
            this.Property(c=>c.OzelKod2).HasMaxLength(50);
            this.Property(c=>c.OzelKod3).HasMaxLength(50);
            this.Property(c=>c.OzelKod4).HasMaxLength(50);
            this.Property(c=>c.VergiDairesi).HasMaxLength(50);
            this.Property(c=>c.VergiNo).HasMaxLength(50);
            this.Property(c => c.IskontoOranı).HasPrecision(5, 2);
            this.Property(c => c.RiskLimiti).HasPrecision(12, 2);
            this.Property(c => c.AlisOzelFiyati).HasMaxLength(20);
            this.Property(c => c.SatisOzelFiyati).HasMaxLength(20);
            this.Property(c => c.Aciklama).HasMaxLength(200);


            this.ToTable("Cariler");
            this.Property(c => c.Id).HasColumnName("Id");
            this.Property(c => c.Durumu).HasColumnName("Durumu");
            this.Property(c => c.CariTuru).HasColumnName("CariTuru");
            this.Property(c => c.CariKodu).HasColumnName("CariKodu");
            this.Property(c => c.CariAdi).HasColumnName("CariAdi");
            this.Property(c => c.YetkiliKisi).HasColumnName("YetkiliKisi");
            this.Property(c => c.FaturaUnvani).HasColumnName("FaturaUnvani");
            this.Property(c => c.CepTelefonu).HasColumnName("CepTelefonu");
            this.Property(c => c.Telefon).HasColumnName("Telefon");
            this.Property(c => c.Fax).HasColumnName("Fax");
            this.Property(c => c.EMail).HasColumnName("EMail");
            this.Property(c => c.Web).HasColumnName("Web");
            this.Property(c => c.Il).HasColumnName("Il");
            this.Property(c => c.Ilce).HasColumnName("Ilce");
            this.Property(c => c.Semt).HasColumnName("Semt");
            this.Property(c => c.Adres).HasColumnName("Adres");
            this.Property(c => c.CariGrubu).HasColumnName("CariGrubu");
            this.Property(c => c.CariAltGrubu).HasColumnName("CariAltGrubu");
            this.Property(c => c.OzelKod1).HasColumnName("OzelKod1");
            this.Property(c => c.OzelKod2).HasColumnName("OzelKod2");
            this.Property(c => c.OzelKod3).HasColumnName("OzelKod3");
            this.Property(c => c.OzelKod4).HasColumnName("OzelKod4");
            this.Property(c => c.VergiDairesi).HasColumnName("VergiDairesi");
            this.Property(c => c.VergiNo).HasColumnName("VergiNo");
            this.Property(c => c.IskontoOranı).HasColumnName("IskontoOranı");
            this.Property(c => c.RiskLimiti).HasColumnName("RiskLimiti");
            this.Property(c => c.AlisOzelFiyati).HasColumnName("AlisOzelFiyati");
            this.Property(c => c.SatisOzelFiyati).HasColumnName("SatisOzelFiyati");
            this.Property(c => c.Aciklama).HasColumnName("Aciklama");
        }
    }
}

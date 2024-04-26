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
            this.Property(x => x.FaturaUnvani).HasMaxLength(50);
            this.Property(x => x.CepTelefonu).HasMaxLength(50);
            this.Property(x => x.Il).HasMaxLength(50);
            this.Property(x => x.Ilce).HasMaxLength(50);
            this.Property(x => x.Semt).HasMaxLength(50);
            this.Property(x => x.Adres).HasMaxLength(50);
            this.Property(x => x.VergiDairesi).HasMaxLength(50);
            this.Property(x => x.VergiNo).HasMaxLength(50);
            this.Property(x => x.BelgeNo).HasMaxLength(30);
            this.Property(x => x.IskontoOrani).HasPrecision(5, 2);
            this.Property(x => x.IskontoTutar).HasPrecision(12, 2);
            this.Property(x => x.ToplamTutar).HasPrecision(12, 2);
            this.Property(x=>x.Aciklama).HasMaxLength(300);

            this.ToTable("Fisler");
            this.Property(x => x.Id).HasColumnName("Id");
            this.Property(x => x.FisKodu).HasColumnName("FisKodu");
            this.Property(x => x.FisTuru).HasColumnName("FisTuru");
            this.Property(x => x.CariId).HasColumnName("CariId");
            this.Property(x => x.FaturaUnvani).HasColumnName("FaturaUnvani");
            this.Property(x => x.CepTelefonu).HasColumnName("CepTelefonu");
            this.Property(x => x.Il).HasColumnName("Il");
            this.Property(x => x.Ilce).HasColumnName("Ilce");
            this.Property(x => x.Semt).HasColumnName("Semt");
            this.Property(x => x.Adres).HasColumnName("Adres");
            this.Property(x => x.VergiDairesi).HasColumnName("VergiDairesi");
            this.Property(x => x.VergiNo).HasColumnName("VergiNo");
            this.Property(x => x.BelgeNo).HasColumnName("BelgeNo");
            this.Property(x => x.Tarih).HasColumnName("Tarih");
            this.Property(x => x.PlasiyerId).HasColumnName("PlasiyerId");
            this.Property(x => x.IskontoOrani).HasColumnName("IskontoOrani");
            this.Property(x => x.IskontoTutar).HasColumnName("IskontoTutar");
            this.Property(x => x.ToplamTutar).HasColumnName("ToplamTutar");
            this.Property(x => x.Aciklama).HasColumnName("Aciklama");

            this.HasOptional(c => c.Cari).WithMany(c => c.Fis).HasForeignKey(c => c.CariId);
            this.HasOptional(c => c.Personel).WithMany(c => c.Fis).HasForeignKey(c => c.PlasiyerId);
        }
    }
}

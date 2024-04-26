using SonicHesap.Entities.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
            this.Property(x => x.Tutar).HasPrecision(12, 2);
            this.Property(x => x.Aciklama).HasMaxLength(300);

            this.ToTable("KasaHareketleri");
            this.Property(x => x.Id).HasColumnName("Id");
            this.Property(x => x.FisKodu).HasColumnName("FisKodu");
            this.Property(x => x.Hareket).HasColumnName("Hareket");
            this.Property(x => x.KasaId).HasColumnName("KasaId");
            this.Property(x => x.OdemeTuruId).HasColumnName("OdemeTuruId");
            this.Property(x => x.CariId).HasColumnName("CariId");
            this.Property(x => x.Tarih).HasColumnName("Tarih");
            this.Property(x => x.Tutar).HasColumnName("Tutar"); 
            this.Property(x => x.Aciklama).HasColumnName("Aciklama");

            this.HasRequired(c=>c.Kasa).WithMany(c=>c.KasaHareket).HasForeignKey(x=>x.KasaId);
            this.HasRequired(c => c.OdemeTuru).WithMany(c => c.KasaHareket).HasForeignKey(c => c.OdemeTuruId);
            this.HasOptional(c=>c.Cari).WithMany(c=>c.KasaHareket).HasForeignKey(c=>c.CariId);
        }
    }
}

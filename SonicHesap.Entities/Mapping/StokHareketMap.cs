using SonicHesap.Entities.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace SonicHesap.Entities.Mapping
{
    public class StokHareketMap:EntityTypeConfiguration<StokHareket>
    {
        public StokHareketMap()
        {
            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(x=>x.FisKodu).HasMaxLength(15);
            this.Property(x=>x.Hareket).HasMaxLength(15);
            this.Property(x => x.Miktar).HasPrecision(12, 3);
            this.Property(x => x.BirimFiyati).HasPrecision(12, 2);
            this.Property(x => x.IndirimOrani).HasPrecision(5, 2);
            this.Property(x => x.SeriNo).HasMaxLength(200);
            this.Property(x => x.Aciklama).HasMaxLength(300);

            this.ToTable("StokHareketleri"); 
            this.Property(x => x.Id).HasColumnName("Id");
            this.Property(x => x.FisKodu).HasColumnName("FisKodu");
            this.Property(x => x.Hareket).HasColumnName("Hareket");
            this.Property(x => x.StokId).HasColumnName("StokId");
            this.Property(x => x.Miktar).HasColumnName("Miktar");
            this.Property(x => x.Kdv).HasColumnName("Kdv");
            this.Property(x => x.BirimFiyati).HasColumnName("BirimFiyati");
            this.Property(x => x.IndirimOrani).HasColumnName("IndirimOrani");
            this.Property(x => x.DepoId).HasColumnName("DepoId"); 
            this.Property(x => x.SeriNo).HasColumnName("SeriNo");
            this.Property(x => x.Tarih).HasColumnName("Tarih");
            this.Property(x => x.Aciklama).HasColumnName("Aciklama");

            this.HasRequired(c => c.Stok).WithMany(c => c.StokHareket).HasForeignKey(x => x.StokId);
            this.HasRequired(c => c.Depo).WithMany(c => c.StokHareket).HasForeignKey(x => x.DepoId);

        }
    }
}

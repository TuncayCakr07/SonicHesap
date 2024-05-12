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
    public class KodMap:EntityTypeConfiguration<Kod>
    {
        public KodMap()
        {
            this.HasKey(c => c.Id);
            this.Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(c => c.OnEki).HasMaxLength(10);
            this.Property(c => c.Tablo).HasMaxLength(20);


            this.ToTable("Kodlar");
            this.Property(c => c.Id).HasColumnName("Id");
            this.Property(c => c.OnEki).HasColumnName("OnEki");
            this.Property(c => c.Tablo).HasColumnName("Tablo");
            this.Property(c => c.SonDeger).HasColumnName("SonDeger");
        }
    }
}

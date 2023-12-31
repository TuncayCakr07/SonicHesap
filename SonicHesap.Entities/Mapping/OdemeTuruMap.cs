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
    public class OdemeTuruMap:EntityTypeConfiguration<OdemeTuru>
    {
        public OdemeTuruMap()
        {
            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(x => x.OdemeTuruKodu).HasMaxLength(15);
            this.Property(x => x.OdemeTuruAdi).HasMaxLength(30);
            this.Property(c => c.Aciklama).HasMaxLength(200);

            this.ToTable("OdemeTurleri");
            this.Property(x => x.Id).HasColumnName("Id");
            this.Property(x => x.OdemeTuruKodu).HasColumnName("OdemeTuruKodu");
            this.Property(x => x.OdemeTuruAdi).HasColumnName("OdemeTuruAdi");
            this.Property(c => c.Aciklama).HasColumnName("Aciklama");
        }
    }
}

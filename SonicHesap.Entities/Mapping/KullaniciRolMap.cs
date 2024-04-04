using SonicHesap.Entities.Repositories;
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
    public class KullaniciRolMap:EntityTypeConfiguration<KullaniciRol>
    {
        public KullaniciRolMap()
        {
            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(x=>x.KullaniciAdi).HasMaxLength(20);
            this.Property(x=>x.FormAdi).HasMaxLength(30);
            this.Property(x=>x.KontrolAdi).HasMaxLength(30);

            this.ToTable("KullaniciRolleri");
            this.Property(x => x.Id).HasColumnName("Id");
            this.Property(x => x.KullaniciAdi).HasColumnName("KullaniciAdi");
            this.Property(x => x.RootId).HasColumnName("RootId");
            this.Property(x => x.ParentId).HasColumnName("ParentId");
            this.Property(x => x.FormAdi).HasColumnName("FormAdi");
            this.Property(x => x.KontrolAdi).HasColumnName("KontrolAdi");
            this.Property(x => x.Yetki).HasColumnName("Yetki");
        }
    }
}

namespace SonicHesap.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cariler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Durumu = c.Boolean(nullable: false),
                        CariTuru = c.String(maxLength: 20),
                        CariKodu = c.String(maxLength: 20),
                        CariAdi = c.String(maxLength: 50),
                        YetkiliKisi = c.String(maxLength: 50),
                        FaturaUnvani = c.String(maxLength: 50),
                        CepTelefonu = c.String(maxLength: 50),
                        Telefon = c.String(maxLength: 50),
                        Fax = c.String(maxLength: 50),
                        EMail = c.String(maxLength: 50),
                        Web = c.String(maxLength: 50),
                        Il = c.String(maxLength: 50),
                        Ilce = c.String(maxLength: 50),
                        Semt = c.String(maxLength: 50),
                        Adres = c.String(maxLength: 200),
                        CariGrubu = c.String(maxLength: 50),
                        CariAltGrubu = c.String(maxLength: 50),
                        OzelKod1 = c.String(maxLength: 50),
                        OzelKod2 = c.String(maxLength: 50),
                        OzelKod3 = c.String(maxLength: 50),
                        OzelKod4 = c.String(maxLength: 50),
                        VergiDairesi = c.String(maxLength: 50),
                        VergiNo = c.String(maxLength: 50),
                        IskontoOranı = c.Decimal(precision: 5, scale: 2),
                        RiskLimiti = c.Decimal(precision: 12, scale: 2),
                        AlisOzelFiyati = c.String(maxLength: 20),
                        SatisOzelFiyati = c.String(maxLength: 20),
                        Aciklama = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Depolar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DepoKodu = c.String(maxLength: 15),
                        DepoAdi = c.String(maxLength: 30),
                        YetkiliKodu = c.String(maxLength: 15),
                        YetkiliAdi = c.String(maxLength: 50),
                        Il = c.String(maxLength: 50),
                        Ilce = c.String(maxLength: 50),
                        Semt = c.String(maxLength: 50),
                        Adres = c.String(maxLength: 200),
                        Telefon = c.String(maxLength: 50),
                        Aciklama = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EFAppointments",
                c => new
                    {
                        UniqueID = c.Int(nullable: false, identity: true),
                        Type = c.Int(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        AllDay = c.Boolean(nullable: false),
                        Subject = c.String(),
                        Location = c.String(),
                        Description = c.String(),
                        Status = c.Int(nullable: false),
                        Label = c.Int(nullable: false),
                        ResourceIDs = c.String(),
                        ReminderInfo = c.String(),
                        RecurrenceInfo = c.String(),
                    })
                .PrimaryKey(t => t.UniqueID);
            
            CreateTable(
                "dbo.EFResources",
                c => new
                    {
                        UniqueID = c.Int(nullable: false, identity: true),
                        ResourceID = c.Int(nullable: false),
                        ResourceName = c.String(),
                        Color = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UniqueID);
            
            CreateTable(
                "dbo.Fisler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FisKodu = c.String(maxLength: 15),
                        FisTuru = c.String(maxLength: 30),
                        CariKodu = c.String(maxLength: 15),
                        CariAdi = c.String(maxLength: 50),
                        FaturaUnvani = c.String(maxLength: 50),
                        CepTelefonu = c.String(maxLength: 50),
                        Il = c.String(maxLength: 50),
                        Ilce = c.String(maxLength: 50),
                        Semt = c.String(maxLength: 50),
                        Adres = c.String(maxLength: 50),
                        VergiDairesi = c.String(maxLength: 50),
                        VergiNo = c.String(maxLength: 50),
                        BelgeNo = c.String(maxLength: 30),
                        Tarih = c.DateTime(nullable: false),
                        PlasiyerKodu = c.String(maxLength: 15),
                        PlasiyerAdi = c.String(maxLength: 50),
                        IskontoOrani = c.Decimal(precision: 5, scale: 2),
                        IskontoTutar = c.Decimal(precision: 12, scale: 2),
                        ToplamTutar = c.Decimal(precision: 12, scale: 2),
                        Aciklama = c.String(maxLength: 300),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.HizliSatisGruplari",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GrupAdi = c.String(maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.HizliSatislar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Barkod = c.String(maxLength: 20),
                        UrunAdi = c.String(maxLength: 50),
                        HizliSatisGrup_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.HizliSatisGruplari", t => t.HizliSatisGrup_Id)
                .Index(t => t.HizliSatisGrup_Id);
            
            CreateTable(
                "dbo.Indirimler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Durumu = c.Boolean(nullable: false),
                        StokKodu = c.String(maxLength: 15),
                        Barkod = c.String(maxLength: 20),
                        StokAdi = c.String(maxLength: 50),
                        IndirimTuru = c.String(maxLength: 20),
                        BaslangicTarihi = c.DateTime(),
                        BitisTarihi = c.DateTime(),
                        IndirimOrani = c.Decimal(nullable: false, precision: 5, scale: 2),
                        Aciklama = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.KasaHareketleri",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FisKodu = c.String(maxLength: 15),
                        Hareket = c.String(maxLength: 15),
                        KasaKodu = c.String(maxLength: 15),
                        KasaAdi = c.String(maxLength: 30),
                        OdemeTuruKodu = c.String(maxLength: 15),
                        OdemeTuruAdi = c.String(maxLength: 30),
                        CariKodu = c.String(maxLength: 15),
                        CariAdi = c.String(maxLength: 50),
                        Tarih = c.DateTime(),
                        Tutar = c.Decimal(precision: 12, scale: 2),
                        Aciklama = c.String(maxLength: 300),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Kasalar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KasaKodu = c.String(maxLength: 15),
                        KasaAdi = c.String(maxLength: 30),
                        YetkiliKodu = c.String(maxLength: 15),
                        YetkiliAdi = c.String(maxLength: 50),
                        Aciklama = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OdemeTurleri",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OdemeTuruKodu = c.String(maxLength: 15),
                        OdemeTuruAdi = c.String(maxLength: 30),
                        Aciklama = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Personeller",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Calisiyor = c.Boolean(nullable: false),
                        Unvani = c.String(maxLength: 20),
                        PersonelKodu = c.String(maxLength: 20),
                        PersonelAdi = c.String(maxLength: 50),
                        TcKimlikNo = c.String(maxLength: 11),
                        IseGirisTarihi = c.DateTime(),
                        IstenCikisTarihi = c.DateTime(),
                        VergiDairesi = c.String(),
                        VergiNo = c.String(),
                        CepTelefonu = c.String(maxLength: 20),
                        Telefon = c.String(maxLength: 20),
                        Fax = c.String(maxLength: 20),
                        EMail = c.String(maxLength: 50),
                        Web = c.String(maxLength: 50),
                        Il = c.String(maxLength: 50),
                        Ilce = c.String(maxLength: 50),
                        Semt = c.String(maxLength: 50),
                        Adres = c.String(maxLength: 200),
                        PrimOrani = c.Decimal(precision: 5, scale: 2),
                        AylikMaasi = c.Decimal(precision: 12, scale: 2),
                        Aciklama = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StokHareketleri",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FisKodu = c.String(maxLength: 15),
                        Hareket = c.String(maxLength: 15),
                        StokKodu = c.String(maxLength: 15),
                        StokAdi = c.String(maxLength: 50),
                        BarkodTuru = c.String(maxLength: 15),
                        Barkod = c.String(maxLength: 20),
                        Birimi = c.String(maxLength: 15),
                        Miktar = c.Decimal(precision: 12, scale: 3),
                        Kdv = c.Int(nullable: false),
                        BirimFiyati = c.Decimal(precision: 12, scale: 2),
                        IndirimOrani = c.Decimal(precision: 5, scale: 2),
                        DepoKodu = c.String(maxLength: 15),
                        DepoAdi = c.String(maxLength: 50),
                        SeriNo = c.String(maxLength: 200),
                        Tarih = c.DateTime(),
                        Aciklama = c.String(maxLength: 300),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Stoklar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Durumu = c.Boolean(nullable: false),
                        StokKodu = c.String(maxLength: 12),
                        StokAdi = c.String(nullable: false, maxLength: 50),
                        Barkod = c.String(maxLength: 20),
                        BarkodTuru = c.String(maxLength: 20),
                        Birimi = c.String(maxLength: 20),
                        StokGrubu = c.String(maxLength: 30),
                        StokAltGrubu = c.String(maxLength: 30),
                        Marka = c.String(maxLength: 30),
                        Modeli = c.String(maxLength: 30),
                        OzelKod1 = c.String(maxLength: 30),
                        OzelKod2 = c.String(maxLength: 30),
                        OzelKod3 = c.String(maxLength: 30),
                        OzelKod4 = c.String(maxLength: 30),
                        GarantiSuresi = c.String(maxLength: 20),
                        UreticiKodu = c.String(maxLength: 20),
                        AlisKdv = c.Int(nullable: false),
                        SatisKdv = c.Int(nullable: false),
                        AlisFiyati1 = c.Decimal(precision: 12, scale: 2),
                        AlisFiyati2 = c.Decimal(precision: 12, scale: 2),
                        AlisFiyati3 = c.Decimal(precision: 12, scale: 2),
                        SatisFiyati1 = c.Decimal(precision: 12, scale: 2),
                        SatisFiyati2 = c.Decimal(precision: 12, scale: 2),
                        SatisFiyati3 = c.Decimal(precision: 12, scale: 2),
                        MinStokMiktarı = c.Decimal(precision: 12, scale: 3),
                        MaxStokMiktarı = c.Decimal(precision: 12, scale: 3),
                        Aciklama = c.String(maxLength: 300),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tanimlar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Turu = c.String(maxLength: 15),
                        Tanimi = c.String(maxLength: 30),
                        Aciklama = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.HizliSatislar", "HizliSatisGrup_Id", "dbo.HizliSatisGruplari");
            DropIndex("dbo.HizliSatislar", new[] { "HizliSatisGrup_Id" });
            DropTable("dbo.Tanimlar");
            DropTable("dbo.Stoklar");
            DropTable("dbo.StokHareketleri");
            DropTable("dbo.Personeller");
            DropTable("dbo.OdemeTurleri");
            DropTable("dbo.Kasalar");
            DropTable("dbo.KasaHareketleri");
            DropTable("dbo.Indirimler");
            DropTable("dbo.HizliSatislar");
            DropTable("dbo.HizliSatisGruplari");
            DropTable("dbo.Fisler");
            DropTable("dbo.EFResources");
            DropTable("dbo.EFAppointments");
            DropTable("dbo.Depolar");
            DropTable("dbo.Cari");
        }
    }
}

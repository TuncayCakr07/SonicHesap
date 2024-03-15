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
        CariTuru = c.String(maxLength: 50),
        CariKodu = c.String(maxLength: 50),
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
        IskontoOranı = c.Decimal(nullable: false, precision: 5, scale: 2),
        RiskLimiti = c.Decimal(nullable: false, precision: 12, scale: 2),
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
        BelgeNo = c.String(maxLength: 30),
        Tarih = c.DateTime(nullable: false),
        PlasiyerKodu = c.String(maxLength: 15),
        PlasiyerAdi = c.String(maxLength: 50),
        IskontoOrani = c.Decimal(nullable: false, precision: 5, scale: 2),
        IskontoTutar = c.Decimal(nullable: false, precision: 12, scale: 2),
        ToplamTutar = c.Decimal(nullable: false, precision: 12, scale: 2),
        Aciklama = c.String(maxLength: 300),
    })
    .PrimaryKey(t => t.Id);

            CreateTable(
    "dbo.HizliSatis",
    c => new
    {
        Id = c.Int(nullable: false, identity: true),
        Barkod = c.String(),
        UrunAdi = c.String(),
        HizliSatisGrup_Id = c.Int(),
    })
    .PrimaryKey(t => t.Id)
    .ForeignKey("dbo.HizliSatisGrup", t => t.HizliSatisGrup_Id)
    .Index(t => t.HizliSatisGrup_Id);

            CreateTable(
    "dbo.HizliSatisGrup",
    c => new
    {
        Id = c.Int(nullable: false, identity: true),
        GrupAdi = c.String(),
    })
    .PrimaryKey(t => t.Id);


            CreateTable(
    "dbo.Indirim",
    c => new
    {
        Id = c.Int(nullable: false, identity: true),
        Durumu = c.Boolean(nullable: false),
        StokKodu = c.String(maxLength: 50),
        Barkod = c.String(maxLength: 50),
        StokAdi = c.String(maxLength: 50),
        IndirimTuru = c.String(maxLength: 50),
        BaslangicTarihi = c.DateTime(),
        BitisTarihi = c.DateTime(),
        IndirimOrani = c.Decimal(nullable: false, precision: 18, scale: 2),
        Aciklama = c.String(maxLength: 200),
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
        Tarih = c.DateTime(nullable: false),
        Tutar = c.Decimal(nullable: false, precision: 18, scale: 2),
        Aciklama = c.String(maxLength: 300),
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
                    Unvani = c.String(maxLength: 50),
                    PersonelKodu = c.String(maxLength: 15),
                    PersonelAdi = c.String(maxLength: 50),
                    TcKimlikNo = c.String(maxLength: 11),
                    IseGirisTarihi = c.DateTime(),
                    IstenCikisTarihi = c.DateTime(),
                    VergiDairesi = c.String(maxLength: 50),
                    VergiNo = c.String(maxLength: 50),
                    CepTelefonu = c.String(maxLength: 50),
                    Telefon = c.String(maxLength: 50),
                    Fax = c.String(maxLength: 50),
                    EMail = c.String(maxLength: 50),
                    Web = c.String(maxLength: 50),
                    Il = c.String(maxLength: 50),
                    Ilce = c.String(maxLength: 50),
                    Semt = c.String(maxLength: 50),
                    Adres = c.String(maxLength: 200),
                    PrimOrani = c.Decimal(nullable: false, precision: 18, scale: 2),
                    AylikMaasi = c.Decimal(nullable: false, precision: 18, scale: 2),
                    Aciklama = c.String(maxLength: 200),
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
        AlisFiyati1 = c.Decimal(nullable: false, precision: 18, scale: 2),
        AlisFiyati2 = c.Decimal(nullable: false, precision: 18, scale: 2),
        AlisFiyati3 = c.Decimal(nullable: false, precision: 18, scale: 2),
        SatisFiyati1 = c.Decimal(nullable: false, precision: 18, scale: 2),
        SatisFiyati2 = c.Decimal(nullable: false, precision: 18, scale: 2),
        SatisFiyati3 = c.Decimal(nullable: false, precision: 18, scale: 2),
        MinStokMiktari = c.Decimal(nullable: false, precision: 18, scale: 3),
        MaxStokMiktari = c.Decimal(nullable: false, precision: 18, scale: 3),
        Aciklama = c.String(maxLength: 300),
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
        Miktar = c.Decimal(nullable: false, precision: 18, scale: 3),
        Kdv = c.Int(nullable: false),
        BirimFiyati = c.Decimal(nullable: false, precision: 18, scale: 2),
        IndirimOrani = c.Decimal(nullable: false, precision: 18, scale: 2),
        IndirimTutari = c.Decimal(nullable: false, precision: 18, scale: 2),
        ToplamTutar = c.Decimal(nullable: false, precision: 18, scale: 2),
        DepoKodu = c.String(maxLength: 15),
        DepoAdi = c.String(maxLength: 50),
        SeriNo = c.String(maxLength: 200),
        Tarih = c.DateTime(nullable: false),
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

            CreateTable(
                    "dbo.HizliSatisGrup",
                    c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GrupAdi = c.String(),
                    })
                    .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.HizliSatis",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Barkod = c.String(),
                    UrunAdi = c.String(),
                    HizliSatisGrup_Id = c.Int(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.HizliSatisGrup", t => t.HizliSatisGrup_Id)
                .Index(t => t.HizliSatisGrup_Id);

        }


        public override void Down()
        {
            DropTable("dbo.Tanimlar");
            DropTable("dbo.StokHareketleri");
            DropTable("dbo.Stoklar");
            DropTable("dbo.OdemeTurleri");
            DropTable("dbo.Kasalar");
            DropTable("dbo.KasaHareketleri");
            DropTable("dbo.Fisler");
            DropTable("dbo.Depolar");
            DropTable("dbo.Cariler");
            DropForeignKey("dbo.HizliSatis", "HizliSatisGrup_Id", "dbo.HizliSatisGrup");
            DropIndex("dbo.HizliSatis", new[] { "HizliSatisGrup_Id" });
            DropTable("dbo.HizliSatis");
            DropTable("dbo.HizliSatisGrup");
        }

    }
}

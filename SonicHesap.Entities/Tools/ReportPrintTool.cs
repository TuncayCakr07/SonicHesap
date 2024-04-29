using DevExpress.XtraReports.UI;
using SonicHesap.Entities.Context;
using SonicHesap.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SonicHesap.Entities.Tools
{
    public class ReportsPrintTool
    {
        public enum Belge
        {
            BilgiFisi,
            Fatura,
            Diger
        }

        public void RaporYazdir(XtraReport rapor, Belge belge)
        {
            ReportPrintTool raporYazdir = new ReportPrintTool(rapor);
            string yaziciAdi=null;
            int ayar = 0;
            switch (belge)
            {
                case Belge.Fatura:
                    ayar = Convert.ToInt32(SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_FaturaYazdirmaAyari));
                    yaziciAdi = SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_FaturaYazici);
                    break;
                case Belge.BilgiFisi:
                    ayar = Convert.ToInt32(SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_BilgiFisiYazdirmaAyari));
                    yaziciAdi = SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_BilgiFisiYazici);
                    break;
                case Belge.Diger:
                    break;
                default:
                    break;
            }

            switch (ayar)
            {
                case 0:
                    raporYazdir.Print(yaziciAdi);
                    break;
                case 1:
                    raporYazdir.PrintDialog();
                    break;
                case 2:
                    raporYazdir.ShowPreviewDialog();
                    break;
            }
        }

        public class Yazdir
        {
            public string FisKodu { get; set; }

            public Yazdir(string fiskodu)
            {
                FisKodu = fiskodu;
            }

            public void Yazdirma()
            {
                try
                {
                    XtraReport rapor = new XtraReport();

                    // Rapor içeriğini tasarlayın - Örnek bir rapor tasarımı
                    rapor.Bands.Add(new DetailBand());

                    // Veritabanından verileri çekerek SampleData listesini doldur
                    List<SampleData> sampleDataList = GetSatisVerileri();

                    foreach (var item in sampleDataList)
                    {
                        XRLabel labelUrunAdi = new XRLabel();
                        labelUrunAdi.Text = item.UrunAd;
                        labelUrunAdi.ForeColor = Color.Black;
                        labelUrunAdi.BackColor = Color.Transparent;
                        labelUrunAdi.Font = new Font("Arial", 10, FontStyle.Regular);
                        labelUrunAdi.LocationF = new PointF(10, 10);
                        rapor.Bands[BandKind.Detail].Controls.Add(labelUrunAdi);

                        XRLabel labelMiktar = new XRLabel();
                        labelMiktar.Text = item.Miktar.ToString();
                        labelMiktar.ForeColor = Color.Black;
                        labelMiktar.BackColor = Color.Transparent;
                        labelMiktar.Font = new Font("Arial", 10, FontStyle.Regular);
                        labelMiktar.LocationF = new PointF(150, 10);
                        rapor.Bands[BandKind.Detail].Controls.Add(labelMiktar);

                        XRLabel labelFiyat = new XRLabel();
                        labelFiyat.Text = item.Fiyat.ToString("C2");
                        labelFiyat.ForeColor = Color.Black;
                        labelFiyat.BackColor = Color.Transparent;
                        labelFiyat.Font = new Font("Arial", 10, FontStyle.Regular);
                        labelFiyat.LocationF = new PointF(250, 10);
                        rapor.Bands[BandKind.Detail].Controls.Add(labelFiyat);

                        XRLabel labelTutar = new XRLabel();
                        labelTutar.Text = item.Tutar.ToString("C2");
                        labelTutar.ForeColor = Color.Black;
                        labelTutar.BackColor = Color.Transparent;
                        labelTutar.Font = new Font("Arial", 10, FontStyle.Regular);
                        labelTutar.LocationF = new PointF(350, 10);
                        rapor.Bands[BandKind.Detail].Controls.Add(labelTutar);
                    }

                    ReportsPrintTool printTool = new ReportsPrintTool();
                    printTool.RaporYazdir(rapor, ReportsPrintTool.Belge.BilgiFisi);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            private List<SampleData> GetSatisVerileri()
            {
                List<SampleData> sampleDataList = new List<SampleData>();

                using (SonicHesapContext db = new SonicHesapContext())
                {
                    // İlgili FisKodu'na ait satışları çek
                    var satislar = db.StokHareketleri.Where(x => x.FisKodu == FisKodu).ToList();

                    foreach (var satis in satislar)
                    {
                        // Her bir satışı SampleData nesnesine dönüştür
                        SampleData data = new SampleData
                        {
                            UrunAd = satis.Stok.StokAdi,
                            Miktar = satis.Miktar ?? 0, // Null değerler için default değer belirle
                            Fiyat = satis.BirimFiyati ?? 0, // Null değerler için default değer belirle
                            Tutar = (satis.Miktar ?? 0) * (satis.BirimFiyati ?? 0) // Tutarı hesapla
                        };

                        sampleDataList.Add(data);
                    }
                }

                return sampleDataList;
            }

            private class SampleData
            {
                public string UrunAd { get; set; }
                public decimal Miktar { get; set; } // int yerine decimal olarak tanımla
                public decimal Fiyat { get; set; } // int yerine decimal olarak tanımla
                public decimal Tutar { get; set; }
            }
        }
    }
}

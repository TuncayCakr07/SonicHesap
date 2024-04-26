using DevExpress.DataAccess.ObjectBinding;
using DevExpress.XtraReports.UI;
using SonicHesap.Entities.Context;
using SonicHesap.Entities.Data_Access;
using SonicHesap.Entities.Tables;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Linq;

namespace SonicHesap.Report.Fatura_Ve_Fiş
{
    public partial class rptBilgiFisi : DevExpress.XtraReports.UI.XtraReport
    {
        public rptBilgiFisi(string fiskodu)
        {
            InitializeComponent();
            SonicHesapContext context = new SonicHesapContext();
            StokHareketDAL stokHareketDal = new StokHareketDAL();
            FisDAL fisDal = new FisDAL();

            Fis fisBilgi = fisDal.GetByFilter(context, c => c.FisKodu == fiskodu);
            ObjectDataSource stokHareketDataSource = new ObjectDataSource { DataSource = stokHareketDal.GetAll(context, c => c.FisKodu == fiskodu) };
            var kullaniciAdi = context.Personeller .Where(c => c.Id ==fisBilgi.Personel.Id).Select(c => c.PersonelAdi).FirstOrDefault();
            lblfisKodu.Text =   "Fiş Kodu  :" + fisBilgi.FisKodu;
            lblKullanici.Text = "Personel  :" + fisBilgi.Personel.PersonelAdi;
            lblCariAdi.Text =   "Müşteri   :" + fisBilgi.Cari.CariAdi;
            lblAdres.Text =     "Adres     :" + fisBilgi.Il + " " + fisBilgi.Ilce + " " + fisBilgi.Semt;
            lblTarih.Text =     "Tarih     :" + fisBilgi.Tarih.ToString();

            this.DataSource = stokHareketDataSource;
            colStokAdi.DataBindings.Add("Text", this.DataSource, "StokAdi");
            colMiktar.DataBindings.Add("Text", this.DataSource, "Miktar");
            colBirimFiyat.DataBindings.Add("Text", this.DataSource, "BirimFiyati");

            CalculatedField calcIndirimTutar = new CalculatedField();
            this.CalculatedFields.Add(calcIndirimTutar);
            calcIndirimTutar.Name = "IndirimTutari";
            calcIndirimTutar.Expression = "([BirimFiyati] * [Miktar]) / 100 * [IndirimOrani]";

            CalculatedField calcKdvToplam = new CalculatedField();
            this.CalculatedFields.Add(calcKdvToplam);
            calcKdvToplam.Name = "KdvTutari";
            calcKdvToplam.Expression = "([BirimFiyati] * [Miktar]) / 100 * [Kdv]";

            CalculatedField calcTutar = new CalculatedField();
            this.CalculatedFields.Add(calcTutar);
            calcTutar.Name = "Tutar";
            calcTutar.Expression = "([BirimFiyati] * [Miktar]) - [KdvTutari] - [IndirimTutari]";

            CalculatedField calcKdvliTutar = new CalculatedField();
            this.CalculatedFields.Add(calcKdvliTutar);
            calcKdvliTutar.Name = "KdvDahil";
            calcKdvliTutar.Expression = "([BirimFiyati] * [Miktar]) - [IndirimTutari]";

            colToplamTutar.DataBindings.Add("Text", this.DataSource, "Tutar");
            lblAraToplam.DataBindings.Add("Text", this.DataSource, "Tutar");
            lblKdvToplam.DataBindings.Add("Text", this.DataSource, "KdvTutari");
            lblGenelToplam.DataBindings.Add("Text", this.DataSource, "KdvDahil");

            XRSummary sumAraToplam = new XRSummary();
            sumAraToplam.Func = SummaryFunc.Sum;
            sumAraToplam.Running = SummaryRunning.Report;
            sumAraToplam.FormatString = "{0:C2}";

            XRSummary sumKdvToplam = new XRSummary();
            sumKdvToplam.Func = SummaryFunc.Sum;
            sumKdvToplam.Running = SummaryRunning.Report;
            sumKdvToplam.FormatString = "{0:C2}";

            XRSummary sumGenelToplam = new XRSummary();
            sumGenelToplam.Func = SummaryFunc.Sum;
            sumGenelToplam.Running = SummaryRunning.Report;
            sumGenelToplam.FormatString = "{0:C2}";

            lblAraToplam.Summary = sumAraToplam;
            lblKdvToplam.Summary = sumKdvToplam;
            lblGenelToplam.Summary = sumGenelToplam;
        }

    }
}

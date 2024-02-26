using DevExpress.DataAccess.ObjectBinding;
using DevExpress.XtraReports.UI;
using SonicHesap.Entities.Context;
using SonicHesap.Entities.Data_Access;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace SonicHesap.Report.Stok
{
    public partial class rptStokHareketleri : DevExpress.XtraReports.UI.XtraReport
    {
        public rptStokHareketleri()
        {
            InitializeComponent();
            SonicHesapContext context = new SonicHesapContext();
            StokHareketDAL stokHareketDal = new StokHareketDAL();
            ObjectDataSource dataSource = new ObjectDataSource { DataSource = stokHareketDal.GetAll(context) };

            this.DataSource = dataSource;
            colFisKodu.DataBindings.Add("Text", this.DataSource, "FisKodu");
            colHareket.DataBindings.Add("Text", this.DataSource, "Hareket");
            colStokKodu.DataBindings.Add("Text", this.DataSource, "StokKodu");
            colBarkod.DataBindings.Add("Text", this.DataSource, "Barkod");
            colStokAdi.DataBindings.Add("Text", this.DataSource, "StokAdi");
            colBirimi.DataBindings.Add("Text", this.DataSource, "Birimi");
            colKdv.DataBindings.Add("Text", this.DataSource, "Kdv","{0:'%'0}");
            colMiktar.DataBindings.Add("Text", this.DataSource, "Miktar");
            colBirimFiyat.DataBindings.Add("Text", this.DataSource, "BirimFiyati","{0:C2}");
            colIndirimOrani.DataBindings.Add("Text", this.DataSource, "IndirimOrani", "{0:'%'0}");


            CalculatedField calcIndirimTutar = new CalculatedField();
            this.CalculatedFields.Add(calcIndirimTutar);
            calcIndirimTutar.Name = "IndirimTutari";
            calcIndirimTutar.Expression = "([BirimFiyati]*[Miktar]) / 100 * [IndirimOrani]";

            CalculatedField calcTutar = new CalculatedField();
            this.CalculatedFields.Add(calcTutar);
            calcTutar.Name = "Tutar";
            calcTutar.Expression = "([BirimFiyati]*[Miktar]) - [IndirimTutari]";

            colIndirimTutar.DataBindings.Add("Text", null, "IndirimTutari", "{0:C2}");
            colTutar.DataBindings.Add("Text", null, "Tutar", "{0:C2}");

            XRSummary sumIndirimTutari = new XRSummary();
            sumIndirimTutari.Func=SummaryFunc.Sum;
            sumIndirimTutari.Running = SummaryRunning.Group;

            XRSummary sumToplamTutar = new XRSummary();
            sumToplamTutar.Func = SummaryFunc.Sum;
            sumToplamTutar.Running = SummaryRunning.Group;

            //lblIndirimTutar.DataBindings.Add("Text", null, "IndirimTutari");
            //lblToplamTutar.DataBindings.Add("Text", null, "Tutar");
            //lblIndirimTutar.Summary=sumIndirimTutari;
            //lblToplamTutar.Summary = sumToplamTutar;
        }

    }
}

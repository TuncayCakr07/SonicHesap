﻿using DevExpress.DataAccess.ObjectBinding;
using DevExpress.XtraReports.UI;
using SonicHesap.Entities.Context;
using SonicHesap.Entities.Data_Access;
using SonicHesap.Entities.Tables;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace SonicHesap.Report.Fatura_Ve_Fiş
{
    public partial class rptFatura : DevExpress.XtraReports.UI.XtraReport
    {
        public rptFatura(string fisKodu)
        {
            InitializeComponent();
            SonicHesapContext context = new SonicHesapContext();
            StokHareketDAL stokHareketDal = new StokHareketDAL();
            FisDAL fisDal = new FisDAL();

            Fis fisBilgi=fisDal.GetByFilter(context,c=>c.FisKodu==fisKodu);
            ObjectDataSource stokHareketDataSource = new ObjectDataSource { DataSource = stokHareketDal.GetAll(context,c=>c.FisKodu==fisKodu) };

            lblCariAdi.Text = fisBilgi.Cari.CariAdi;
            lblAdres.Text= fisBilgi.Adres;
            lblFaturaTarihi.Text = fisBilgi.Tarih.ToString();
            lblIkametgah.Text = fisBilgi.Semt + "\\" + fisBilgi.Ilce + "\\" + fisBilgi.Il;


            this.DataSource = stokHareketDataSource;
            colStokAdi.DataBindings.Add("Text", this.DataSource, "StokAdi");
            colMiktar.DataBindings.Add("Text", this.DataSource, "Miktar");
            colBirimFiyat.DataBindings.Add("Text", this.DataSource, "BirimFiyati");



            CalculatedField calcIndirimTutar = new CalculatedField();
            this.CalculatedFields.Add(calcIndirimTutar);
            calcIndirimTutar.Name = "IndirimTutari";
            calcIndirimTutar.Expression = "([BirimFiyati]*[Miktar]) / 100 * [IndirimOrani]";

            CalculatedField calcKdvToplam = new CalculatedField();
            this.CalculatedFields.Add(calcKdvToplam);
            calcKdvToplam.Name = "KdvTutari";
            calcKdvToplam.Expression = "([BirimFiyati]*[Miktar]) / 100 * [Kdv]";



            CalculatedField calcTutar = new CalculatedField();
            this.CalculatedFields.Add(calcTutar);
            calcTutar.Name = "Tutar";
            calcTutar.Expression = "([BirimFiyati]*[Miktar]) - [KdvTutari] - [IndirimTutari]";


            CalculatedField calcKdvliTutar = new CalculatedField();
            this.CalculatedFields.Add(calcKdvliTutar);
            calcKdvliTutar.Name = "KdvDahil";
            calcKdvliTutar.Expression = "([BirimFiyati]*[Miktar]) - [IndirimTutari]";

            colToplamTutar.DataBindings.Add("Text",null, "Tutar");



            XRSummary sumAraToplam = new XRSummary();
            sumAraToplam.Func = SummaryFunc.Sum;
            sumAraToplam.Running = SummaryRunning.Page;
            sumAraToplam.FormatString = "{0:C2}";


            XRSummary sumKdvToplam = new XRSummary();
            sumKdvToplam.Func = SummaryFunc.Sum;
            sumKdvToplam.Running = SummaryRunning.Page;
            sumKdvToplam.FormatString = "{0:C2}";

            XRSummary sumGenelToplam = new XRSummary();
            sumGenelToplam.Func = SummaryFunc.Sum;
            sumGenelToplam.Running = SummaryRunning.Page;
            sumGenelToplam.FormatString = "{0:C2}";


            lblAraToplam.DataBindings.Add("Text", null, "Tutar"); 
            lblKdvToplam.DataBindings.Add("Text", null, "KdvTutari"); 
            lblGenelToplam.DataBindings.Add("Text", null, "KdvDahil");


            lblAraToplam.Summary = sumAraToplam;
            lblKdvToplam.Summary=sumKdvToplam;
            lblGenelToplam.Summary=sumGenelToplam;
        }

    }
}

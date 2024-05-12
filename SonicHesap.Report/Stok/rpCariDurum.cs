using DevExpress.DataAccess.ObjectBinding;
using DevExpress.XtraReports.UI;
using SonicHesap.Entities.Context;
using SonicHesap.Entities.Data_Access;
using SonicHesap.Entities.Mapping;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace SonicHesap.Report.Stok
{
    public partial class rpCariDurum : DevExpress.XtraReports.UI.XtraReport
    {
        public rpCariDurum()
        {
            InitializeComponent();
            SonicHesapContext context = new SonicHesapContext();
            CariDAL cariDal=new CariDAL();

            ObjectDataSource dataSource=new ObjectDataSource { DataSource = cariDal.CariListele(context) }; 
            this.DataSource = dataSource;
            colDurumu.DataBindings.Add("Text", this.DataSource, "Durumu");
            colCariTuru.DataBindings.Add("Text", this.DataSource, "CariTuru");
            colCariKodu.DataBindings.Add("Text", this.DataSource, "CariKodu");
            colCariAdi.DataBindings.Add("Text", this.DataSource, "CariAdi");
            colCariGrubu.DataBindings.Add("Text", this.DataSource, "CariGrubu");
            colIskontoOrani.DataBindings.Add("Text", this.DataSource, "IskontoOrani");
            colRiskLimiti.DataBindings.Add("Text", this.DataSource, "RiskLimiti");
            colAlacak.DataBindings.Add("Text", this.DataSource, "Alacak");
            colBorc.DataBindings.Add("Text", this.DataSource, "Borc");
            colBakiye.DataBindings.Add("Text", this.DataSource, "Bakiye");

        }

    }
}

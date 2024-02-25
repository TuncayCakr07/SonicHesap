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
    public partial class rpStokDurum : DevExpress.XtraReports.UI.XtraReport
    {
        public rpStokDurum()
        {
            InitializeComponent();
            SonicHesapContext context =new SonicHesapContext();
            StokDAL stokDal= new StokDAL(); 

            ObjectDataSource stokDataSource = new ObjectDataSource { DataSource = stokDal.StokListele(context)};
            this.DataSource = stokDataSource;

            colStokKodu.DataBindings.Add("Text", this.DataSource, "StokKodu");
            colBarkod.DataBindings.Add("Text", this.DataSource, "Barkod");
            colStokAdi.DataBindings.Add("Text", this.DataSource, "StokAdi");
            colBirimi.DataBindings.Add("Text", this.DataSource, "Birimi");
            colStokGrubu.DataBindings.Add("Text", this.DataSource, "StokGrubu");
            colStokAltGrubu.DataBindings.Add("Text", this.DataSource, "StokAltGrubu");
            colAlisKdv.DataBindings.Add("Text", this.DataSource, "AlisKdv");
            colSatisKdv.DataBindings.Add("Text", this.DataSource, "SatisKdv");
            colStokGiris.DataBindings.Add("Text", this.DataSource, "StokGiris");
            colStokCikis.DataBindings.Add("Text", this.DataSource, "StokCikis");
            colMevcutStok.DataBindings.Add("Text", this.DataSource, "MevcutStok");
        }

    }
}

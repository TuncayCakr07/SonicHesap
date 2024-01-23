using DevExpress.XtraEditors;
using SonicHesap.Entities.Context;
using SonicHesap.Entities.Data_Access;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace SonicHesap.BackOffice.Odeme_Turu
{
    public partial class FrmOdemeTuruHareket : DevExpress.XtraEditors.XtraForm
    {
        SonicHesapContext context = new SonicHesapContext();
        OdemeTuruDAL odemeTuruDal = new OdemeTuruDAL();
        private string _odemeTuruKodu;
        public FrmOdemeTuruHareket(string odemeTuruKodu, string odemeTuruAdi)
        {
            InitializeComponent();
            _odemeTuruKodu = odemeTuruKodu;
            lblBaslik.Text= odemeTuruKodu + " - "+ odemeTuruAdi + "Hareketleri";
        }

        private void FrmOdemeTuruHareket_Load(object sender, EventArgs e)
        {
            Listele();
        }

        void Listele()
        {
            gridContOdemeHareket.DataSource = odemeTuruDal.GetAll(context, c => c.OdemeTuruKodu == _odemeTuruKodu);
            gridContKasaBakiye.DataSource = odemeTuruDal.KasaToplamListele(context, _odemeTuruKodu);
            gridContGenelToplam.DataSource = odemeTuruDal.GenelToplamListele(context, _odemeTuruKodu); 
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
           gridOdemeHareket.OptionsView.ShowAutoFilterRow = false?true:false;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
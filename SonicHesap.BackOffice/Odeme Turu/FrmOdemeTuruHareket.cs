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
        private int _odemeTuruId;
        public FrmOdemeTuruHareket(int odemeTuruId)
        {
            InitializeComponent();
            _odemeTuruId = odemeTuruId;
            var odemeTuruBilgi=context.OdemeTurleri.SingleOrDefault(c=>c.Id==odemeTuruId);  
            lblBaslik.Text= odemeTuruBilgi.OdemeTuruKodu + " - "+ odemeTuruBilgi.OdemeTuruAdi + "Hareketleri";
        }

        private void FrmOdemeTuruHareket_Load(object sender, EventArgs e)
        {
            Listele();
        }

        void Listele()
        {
            gridContOdemeHareket.DataSource = odemeTuruDal.GetAll(context, c => c.Id == _odemeTuruId);
            gridContKasaBakiye.DataSource = odemeTuruDal.KasaToplamListele(context, _odemeTuruId);
            gridContGenelToplam.DataSource = odemeTuruDal.GenelToplamListele(context, _odemeTuruId); 
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
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

namespace SonicHesap.BackOffice.Kasa
{
    public partial class FrmKasaHareket : DevExpress.XtraEditors.XtraForm
    {
        KasaDAL kasaDal=new KasaDAL();
        SonicHesapContext context=new SonicHesapContext();
        private int _kasaId;
        public FrmKasaHareket(int kasaId)
        {
            InitializeComponent();
            _kasaId = kasaId;
            var kasaBilgi = context.Kasalar.SingleOrDefault(c => c.Id == kasaId);
            lblBaslik.Text = kasaBilgi.KasaKodu + " - " + kasaBilgi.KasaAdi + "Hareketleri";
        }

        private void FrmKasaHareket_Load(object sender, EventArgs e)
        {

        }
        public void Guncelle()
        {
            gridContKasaHareket.DataSource = kasaDal.GetAll(context, c => c.Id == _kasaId);
            gridContOdemeTuruToplam.DataSource = kasaDal.OdemeTuruToplamListele(context, _kasaId);
            gridContGenelToplam.DataSource = kasaDal.GenelToplamListele(context, _kasaId);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (gridKasaHareket.OptionsView.ShowAutoFilterRow == true)
            {
                gridKasaHareket.OptionsView.ShowAutoFilterRow = false;
            }
            else
            {
                gridKasaHareket.OptionsView.ShowAutoFilterRow = true;
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
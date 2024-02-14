using DevExpress.XtraEditors;
using SonicHesap.BackOffice.Kasa;
using SonicHesap.Entities.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SonicHesap.BackOffice.Fis
{
    public partial class FrmOdemeEkrani : DevExpress.XtraEditors.XtraForm
    {
        public KasaHareket entity;
        private string _odemeTuruKodu = null;
        public FrmOdemeEkrani(string odemeTuru,string odemeTuruKodu)
        {
            InitializeComponent();
            txtOdemeTuru.Text = odemeTuru;
            _odemeTuruKodu=odemeTuruKodu;
        }

        private void FrmOdemeEkrani_Load(object sender, EventArgs e)
        {
            txtKasaKodu.Enabled = true;
            txtKasaAdi.Enabled = true;
            txtTutar.Enabled = true;
            txtAciklama.Enabled = true;
        }
        private void btnKasaSec_Click(object sender, EventArgs e)
        {
            FrmKasaSecim form= new FrmKasaSecim();
            form.ShowDialog();
            if (form.secildi)
            {
                txtKasaKodu.Text = form.entity.KasaKodu;
                txtKasaAdi.Text = form.entity.KasaAdi;
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string message = null;
            int error = 0;
            if (txtKasaAdi.Text=="")
            {
                message += "Kasa Bilgileri boş Bırakılamaz!" + System.Environment.NewLine;
                error++;
            }

            if (txtTutar.Value<=0)
            {
                message += "Tutar 0 Değerine Eşit Veya 0 Değerinden Küçük Olamaz!" + System.Environment.NewLine;
                error++;
            }

            if (error!=0)
            {
                MessageBox.Show(message, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            entity=new KasaHareket();
            entity.OdemeTuruKodu = _odemeTuruKodu;
            entity.KasaKodu = txtKasaKodu.Text;
            entity.KasaAdi=txtKasaAdi.Text;
            entity.Tutar=txtTutar.Value;
            entity.Aciklama=txtAciklama.Text;
            this.Close();
        }
    }
}
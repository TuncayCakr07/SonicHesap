using DevExpress.XtraEditors;
using SonicHesap.BackOffice.Kasa;
using SonicHesap.Entities.Tables;
using SonicHesap.Entities.Tools;
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
        private Nullable<decimal> gelenTutar;
        public FrmOdemeEkrani(string odemeTuru,string odemeTuruKodu,Nullable<decimal>odenmesiGereken=null)
        {
            InitializeComponent();
            txtOdemeTuru.Text = odemeTuru;
            _odemeTuruKodu=odemeTuruKodu;
            txtKasaKodu.Text = SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_VarsayilanKasa);
            txtKasaAdi.Text = SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_VarsayilanKasaAdi);
            if (odenmesiGereken != null)
            {
                gelenTutar = odenmesiGereken.Value;
            }
            else 
            {
                txtTutar.Properties.Buttons[1].Visible = false;
            }
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

            if (txtTutar.Value > gelenTutar && gelenTutar!=null)
            {
                message += "Eklenen Tutar Ödenmesi Gereken Tutardan Büyük Olamaz!" + System.Environment.NewLine;
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

        private void txtTutar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index==1)
            {
                txtTutar.Value = gelenTutar.Value;
            }
        }
    }
}
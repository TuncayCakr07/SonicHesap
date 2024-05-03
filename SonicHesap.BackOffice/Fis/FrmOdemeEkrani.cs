using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.Unicode;
using SonicHesap.BackOffice.Kasa;
using SonicHesap.Entities.Context;
using SonicHesap.Entities.Tables;
using SonicHesap.Entities.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SonicHesap.BackOffice.Fis
{
    public partial class FrmOdemeEkrani : DevExpress.XtraEditors.XtraForm
    {
        SonicHesapContext context = new SonicHesapContext();
        public KasaHareket entity;
        private Nullable<decimal> gelenTutar;
        private Entities.Tables.Kasa _kasaBilgi;
        OdemeTuru _odemeTuruBilgi;
        public FrmOdemeEkrani(int odemeTuruId, Nullable<decimal> odenmesiGereken = null)
        {
            InitializeComponent();
            int kasaId = Convert.ToInt32(SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_VarsayilanKasa));
            _kasaBilgi = context.Kasalar.SingleOrDefault(c => c.Id == kasaId);
            _odemeTuruBilgi = context.OdemeTurleri.SingleOrDefault(c => c.Id == odemeTuruId);
            txtKasaKodu.Text = _kasaBilgi.KasaKodu;
            txtOdemeTuru.Text = _odemeTuruBilgi.OdemeTuruAdi;
            txtKasaAdi.Text = _kasaBilgi.KasaAdi;
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
            FrmKasaSecim form = new FrmKasaSecim();
            form.ShowDialog();
            if (form.secildi)
            {
                _kasaBilgi = context.Kasalar.SingleOrDefault(c => c.Id == form.entity.Id);
                _kasaBilgi.KasaAdi = txtKasaAdi.Text;
                _kasaBilgi.KasaKodu = txtKasaKodu.Text;
                context.ChangeTracker.DetectChanges();
                context.SaveChanges();
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
            if (txtKasaAdi.Text == "")
            {
                message += "Kasa Bilgileri boş Bırakılamaz!" + System.Environment.NewLine;
                error++;
            }
            if (txtKasaAdi.Text == "")
            {
                message += "Kasa Bilgileri boş Bırakılamaz!" + System.Environment.NewLine;
                error++;
            }

            if (txtTutar.Value <= 0)
            {
                message += "Tutar 0 Değerine Eşit Veya 0 Değerinden Küçük Olamaz!" + System.Environment.NewLine;
                error++;
            }

            if (txtTutar.Value > gelenTutar && gelenTutar != null)
            {
                message += "Eklenen Tutar Ödenmesi Gereken Tutardan Büyük Olamaz!" + System.Environment.NewLine;
                error++;
            }

            if (error != 0)
            {
                MessageBox.Show(message, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            entity = new KasaHareket();
            entity.OdemeTuruId = _odemeTuruBilgi.Id;
            entity.KasaId = _kasaBilgi.Id;
            entity.Tutar = txtTutar.Value;
            entity.Aciklama = txtAciklama.Text;
            _kasaBilgi.KasaAdi = txtKasaAdi.Text;
            _kasaBilgi.KasaKodu = txtKasaKodu.Text;
            context.KasaHareketleri.AddOrUpdate(entity);
            context.SaveChanges();
            this.Close();
        }

        private void txtTutar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                txtTutar.Value = gelenTutar.Value;
            }
        }
    }
}
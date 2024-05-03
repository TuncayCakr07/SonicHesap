using DevExpress.XtraEditors;
using SonicHesap.Entities.Context;
using SonicHesap.Entities.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SonicHesap.Admin
{
    public partial class FrmKullaniciGiris : DevExpress.XtraEditors.XtraForm
    {
        SonicHesapContext context=new SonicHesapContext();
        private bool girisBasarili=false;
        public FrmKullaniciGiris()
        {
            InitializeComponent();
        }

        private async void btnGiris_Click(object sender, EventArgs e)
        {
            GirisYap();
        }

        private void GirisYap()
        {
            if (context.Kullanicilar.Any(c => c.KullaniciAdi == txtKullanici.Text && c.Parola == txtParola.Text))
            {
                girisBasarili = true;
                RoleTool.KullaniciEntity = context.Kullanicilar.SingleOrDefault(c => c.KullaniciAdi == txtKullanici.Text);
                MessageBox.Show("Giriş Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Girmiş Olduğunuz Kullanıcı Bilgileri Hatalıdır!\nLütfen Bilgilerinizi Kontrol Ediniz!", "Kullanıcı Bilgisi Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtKullanici.Text = null;
                txtParola.Text = null;
                this.Close();
            }
        }

        private void FrmKullaniciGiris_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!girisBasarili)
            {
                Application.Exit();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (context.Kullanicilar.Any(c=>c.KullaniciAdi==txtKullanici.Text))
            {
                FrmParolaHatirlat form = new FrmParolaHatirlat(txtKullanici.Text);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bu Kullanıcı Adına Ait Kullanıcı Bulunamadı!","Kullanıcı Hatası!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void FrmKullaniciGiris_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GirisYap();
            }
        }
    }
}
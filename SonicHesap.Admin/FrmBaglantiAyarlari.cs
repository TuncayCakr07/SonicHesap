using DevExpress.XtraEditors;
using SonicHesap.Entities.Context;
using SonicHesap.Entities.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SonicHesap.Admin
{
    public partial class FrmBaglantiAyarlari : DevExpress.XtraEditors.XtraForm
    {
        SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder();
        bool kaydedildi=false;
        public FrmBaglantiAyarlari()
        {
            InitializeComponent();
        }

        private void BaglantiCumleOlustur()
        {
            connectionStringBuilder.DataSource = txtServer.Text;
            connectionStringBuilder.InitialCatalog = txtDBAdi.Text;
            if (chkWindows.Checked)
            {
                connectionStringBuilder.IntegratedSecurity = true;
            }
            else
            {
                connectionStringBuilder.UserID = txtKullaniciAdi.Text;
                connectionStringBuilder.Password = txtParola.Text;
                connectionStringBuilder.IntegratedSecurity = false;
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            BaglantiCumleOlustur();
            connectionStringBuilder.InitialCatalog = "master";
            if (ConnectionTool.CheckConnection(connectionStringBuilder.ConnectionString))
            {
               MessageBox.Show("Veritabanı Bağlantısı Başarıyla Sağlandı","Veritabanı Bağlantısı Uyarısı!",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Veritabanı Bağlantısı Başarısız! Bilgilerinizi Kontrol Ediniz!", "Veritabanı Bağlantısı Uyarısı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void chkSql_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSql.Checked)
            {
                txtParola.Enabled = true;
                txtKullaniciAdi.Enabled = true;
            }
            else
            {
                txtParola.Enabled = false;
                txtKullaniciAdi.Enabled = false;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            BaglantiCumleOlustur();
            connectionStringBuilder.InitialCatalog = "master";
            if (ConnectionTool.CheckConnection(connectionStringBuilder.ConnectionString))
            {
                connectionStringBuilder.InitialCatalog = txtDBAdi.Text;
                MessageBox.Show("Seçtiğiniz Server'da Belirttiğiniz Database Yoksa Bu Mesajdan Sonra Oluşturulacaktır.\n Bu İşlem Uzun Sürebilir..","Veritabanı Kontrol Uyarısı!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                SettingsTool.AyarDegistir(SettingsTool.Ayarlar.DatabaseAyarlari_BaglantiCumlesi, connectionStringBuilder.ConnectionString);
                SettingsTool.Save();
                using (var context = new SonicHesapContext())
                {
                    context.Database.CreateIfNotExists();
                    if (!context.Kullanicilar.Any(c => c.KullaniciAdi == "Yönetici"))
                    {
                        context.Kullanicilar.Add(new Entities.Tables.Kullanici
                        {
                            KullaniciAdi = "Yönetici",
                            Parola = "1234",

                        });
                        context.SaveChanges();
                    }
                }

                kaydedildi = true;
                MessageBox.Show("Veritabanı Bağlantısı Başarıyla Sağlandı", "Veritabanı Bağlantısı Uyarısı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Veritabanı Bağlantısı Başarısız! Bilgilerinizi Kontrol Ediniz!", "Veritabanı Bağlantısı Uyarısı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FrmBaglantiAyarlari_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!kaydedildi)
            {
                MessageBox.Show("Uygulama Bağlantı Cümlesi Olmadığı İçin Kapatılacak!","Form Kapatma!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                Application.Exit();
            }
        }
    }
}
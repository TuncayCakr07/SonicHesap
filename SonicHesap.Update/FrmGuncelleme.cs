using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SonicHesap.Update
{
    public partial class FrmGuncelleme : DevExpress.XtraEditors.XtraForm
    {
        WebClient indir = new WebClient();
        public bool IsGuncellemeTamamlandi { get; set; }

        public FrmGuncelleme()
        {
            InitializeComponent();
            IsGuncellemeTamamlandi = false;
            CheckForIllegalCrossThreadCalls = false;
        }

        private async void simpleButton1_Click(object sender, EventArgs e)
        {
            string tempFolderPath = @"C:\Users\T.ÇAKIROĞLU\source\repos\SonicHesap\SonicHesap.BackOffice\bin\Debug\Temp";

            if (!Directory.Exists(tempFolderPath))
            {
                Directory.CreateDirectory(tempFolderPath);
            }

            indir.DownloadProgressChanged += IndirmeDurumu;
            indir.DownloadFileCompleted += IndirmeBitti;
            indir.DownloadFileAsync(new Uri("https://www.softcakir.com/update.zip"), Path.Combine(tempFolderPath, "update.zip"));
        }

        public void IndirmeDurumu(object sender, DownloadProgressChangedEventArgs e)
        {
            progressFile.Properties.Maximum = (int)e.TotalBytesToReceive;
            progressFile.Text = Convert.ToString(e.BytesReceived);
            lblIndirilenVeri.Text = $"{e.BytesReceived / 1024 / 1024} MB\\{e.TotalBytesToReceive / 1024 / 1024} MB";
        }

        private void IndirmeBitti(object sender, AsyncCompletedEventArgs e)
        {
            try
            {
                if (e.Error != null)
                {
                    MessageBox.Show("İndirme hatası: " + e.Error.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string tempFolderPath = @"C:\Users\T.ÇAKIROĞLU\source\repos\SonicHesap\SonicHesap.BackOffice\bin\Debug\Temp";
                string zipFilePath = Path.Combine(tempFolderPath, "update.zip").TrimStart('\\');
                string xmlFilePath = Path.Combine(tempFolderPath, "Liste.xml").TrimStart('\\');

                ZipFile.ExtractToDirectory(zipFilePath, tempFolderPath);

                if (!File.Exists(xmlFilePath))
                {
                    MessageBox.Show("Liste.xml dosyası bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                XElement dosyalar = XElement.Load(xmlFilePath);

                foreach (var dosya in dosyalar.Elements("Dosya"))
                {
                    string dosyaAdi = dosya.Element("DosyaAdi")?.Value;
                    string yuklenecegiKonum = dosya.Element("YuklenecegiKonum")?.Value;

                    if (!string.IsNullOrEmpty(dosyaAdi) && !string.IsNullOrEmpty(yuklenecegiKonum))
                    {
                        string sourceFile = Path.Combine(tempFolderPath, dosyaAdi);
                        string destinationFile = Path.Combine(Application.StartupPath, yuklenecegiKonum.TrimStart('\\'));

                        if (File.Exists(destinationFile))
                        {
                            File.Delete(destinationFile);
                        }

                        File.Copy(sourceFile, destinationFile);
                    }
                }
                IsGuncellemeTamamlandi = true;
                Directory.Delete(tempFolderPath, true);
                MessageBox.Show("Güncelleme Ve Versiyon Yenileme İşlemi Tamamlandı!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                IsGuncellemeTamamlandi = false;
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmGuncelleme_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!IsGuncellemeTamamlandi)
            {
                e.Cancel = true;
                MessageBox.Show("Güncelleme işlemi tamamlanana kadar formu kapatamazsınız.", "Bekleyin", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            IsGuncellemeTamamlandi = false;
            this.Close();
        }

        private void FrmGuncelleme_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.ComponentModel;
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
        private bool indirmeTamamlandi = false;

        public FrmGuncelleme()
        {
            InitializeComponent();
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
                string zipFilePath = Path.Combine(tempFolderPath, "update.zip");
                string xmlFilePath = Path.Combine(tempFolderPath, "Liste.xml");

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

                Directory.Delete(tempFolderPath, true);
                MessageBox.Show("Güncelleme Ve Versiyon Yenileme İşlemi Tamamlandı!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                indirmeTamamlandi = true;
                this.Close(); // Güncelleme tamamlandığında formu kapat
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmGuncelleme_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!indirmeTamamlandi)
            {
                e.Cancel = true;
                MessageBox.Show("Güncelleme işlemi tamamlanana kadar formu kapatamazsınız.", "Bekleyin", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

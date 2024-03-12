using DevExpress.Utils.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace SonicHesap.Update
{
    public partial class FrmGuncelleme : DevExpress.XtraEditors.XtraForm

    {
        WebClient indir=new WebClient();
        public static bool IsRunning(string ProgramAdi)
        {
            return Process.GetProcessesByName(ProgramAdi).Length > 0;
        }
        public FrmGuncelleme()
        {
            InitializeComponent();
            if (IsRunning("SonicHesap.BackOffice"))
            {
                if (MessageBox.Show("Güncelleme İşleminden Önce Açık Olan Uygulamalarınızın Kapatılması Gerekiyor. Kapatma İşlemini Onaylıyormusunuz?","Uyarı!",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
                {
                    foreach (var process in Process.GetProcessesByName("SonicHesap.BackOffice"))
                    {
                        process.CloseMainWindow();
                        process.Kill();
                    }
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            indir.DownloadProgressChanged += IndirmeDurumu;
            indir.DownloadFileCompleted += IndirmeBitti;

            string tempPath = Application.StartupPath + "\\Temp\\";
            if (!System.IO.Directory.Exists(tempPath))
            {
                System.IO.Directory.CreateDirectory(tempPath);
            }

            string saveFilePath = tempPath + "update.zip";
            indir.DownloadFileAsync(new Uri("https://www.softcakir.com/update.zip"), saveFilePath);
        }

        private void IndirmeBitti(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show("İndirme hatası: " + e.Error.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Güncel Versiyon İndirme İşleminiz Tamamlanmıştır!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void IndirmeDurumu(object sender, DownloadProgressChangedEventArgs e)
        {
            progressFile.Properties.Maximum = (int)e.TotalBytesToReceive;
            progressFile.Text = Convert.ToString(e.BytesReceived);
            lblIndirilenVeri.Text = $"{e.BytesReceived/1024/1024} MB\\{e.TotalBytesToReceive/1024/1024} MB";
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}

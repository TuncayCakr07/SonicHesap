using DevExpress.Utils.About;
using DevExpress.XtraEditors;
using SonicHesap.Entities.Tables.OtherTables;
using SonicHesap.Entities.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SonicHesap.BackOffice.Doviz_Kurlari
{
    public partial class FrmDovizKurlari : DevExpress.XtraEditors.XtraForm
    {
        public FrmDovizKurlari()
        {
            InitializeComponent();
            FileInfo info = new FileInfo(Application.StartupPath + "\\Kurlar.xml");
            lblUyari.Text = "Son Güncelleme Tarihi  :" + info.LastWriteTime.ToString();
        }

        private void FrmDovizKurlari_Load(object sender, EventArgs e)
        {
            Guncelle(false);
        }

        private void Guncelle(bool indir = true)
        {
            if (indir)
            {
                using (System.Net.WebClient kurIndir = new System.Net.WebClient())
                {
                    kurIndir.DownloadFile("https://www.tcmb.gov.tr/kurlar/today.xml", Application.StartupPath + "\\Kurlar.xml");
                }
                lblUyari.Text = "Son Güncelleme Tarihi  :" + DateTime.Now.ToString();
            }
            ExchangeTool doviz=new ExchangeTool();

            gridControl1.DataSource = doviz.DovizKuruCek();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Guncelle();
        }
    }
}
using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;
using DevExpress.XtraReports.UI;
using SonicHesap.Report.Stok;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SonicHesap.BackOffice.Raporlar
{
    public partial class FrmRaporListesi : DevExpress.XtraEditors.XtraForm
    {
        private XtraReport rapor;
        public FrmRaporListesi()
        {
            InitializeComponent();
        }

        private void navBarLink_Click(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            var buton = sender as NavBarItem;
            Type tip = Assembly.Load("SonicHesap.Report").GetTypes().SingleOrDefault(c => c.Name == buton.Name.Replace("link", ""));

             rapor = (XtraReport)Activator.CreateInstance(tip);
            txtRaporAdi.Text = e.Link.Caption;
            txtRaporGrubu.Text = e.Link.Group.Caption;
            txtAciklama.Text=buton.Tag==null ? txtAciklama.Text = null : txtAciklama.Text=buton.Tag.ToString(); 
            filterControl1.SourceControl = rapor.DataSource;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmRaporGoruntuleme form = new FrmRaporGoruntuleme(rapor);
            rapor.FilterString=filterControl1.FilterString;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
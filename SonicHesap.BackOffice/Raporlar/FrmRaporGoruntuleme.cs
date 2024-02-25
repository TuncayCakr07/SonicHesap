using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SonicHesap.BackOffice.Raporlar
{
    public partial class FrmRaporGoruntuleme : DevExpress.XtraEditors.XtraForm
    {
        public FrmRaporGoruntuleme(XtraReport rapor)
        {
            InitializeComponent();
            documentRapor.DocumentSource = rapor;
        }

        private void FrmRaporGoruntuleme_Load(object sender, EventArgs e)
        {

        }
    }
}
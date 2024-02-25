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
    public partial class FrmRaporGoruntule : DevExpress.XtraEditors.XtraForm
    {
        public FrmRaporGoruntule(XtraReport rapor)
        {
            InitializeComponent();
            documentViewer1.DocumentSource = rapor;
        }

        private void FrmRaporGoruntule_Load(object sender, EventArgs e)
        {

        }
    }
}
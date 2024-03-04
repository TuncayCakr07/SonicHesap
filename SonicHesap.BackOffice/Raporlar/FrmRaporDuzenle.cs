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
    public partial class FrmRaporDuzenle : DevExpress.XtraEditors.XtraForm
    {
        public FrmRaporDuzenle(XtraReport rapor=null)
        {
            InitializeComponent();
            reportDesigner1.OpenReport(rapor);
        }
    }
}
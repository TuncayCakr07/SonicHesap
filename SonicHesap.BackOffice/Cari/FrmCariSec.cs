using DevExpress.XtraEditors;
using SonicHesap.Entities.Context;
using SonicHesap.Entities.Data_Access;
using SonicHesap.Entities.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SonicHesap.BackOffice.Cari
{
    public partial class FrmCariSec : DevExpress.XtraEditors.XtraForm
    {
        CariDAL cariDAL = new CariDAL();
        SonicHesapContext context = new SonicHesapContext();
        public List<Entities.Tables.Cari> secilen = new List<Entities.Tables.Cari>();
        public FrmCariSec(bool cokluSecim = false)
        {
            InitializeComponent();
            if (cokluSecim)
            {
                lblUyari.Visible = true;
                gridView1.OptionsSelection.MultiSelect = true;
            }
        }

        private void FrmCariSec_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = cariDAL.GetCariler(context);
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            foreach (var row in gridView1.GetSelectedRows())
            {
                string cariKodu = gridView1.GetRowCellValue(row, colCariKodu).ToString();
                secilen.Add(context.Cariler.SingleOrDefault(c => c.CariKodu == cariKodu));
            }
            this.Close();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
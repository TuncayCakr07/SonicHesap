using DevExpress.XtraEditors;
using SonicHesap.Entities.Context;
using SonicHesap.Entities.Data_Access;
using SonicHesap.Entities.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SonicHesap.BackOffice.Stok
{
    public partial class FrmStokSec : DevExpress.XtraEditors.XtraForm
    {
        StokDAL stokDal=new StokDAL();
        SonicHesapContext context=new SonicHesapContext();
        public List<Entities.Tables.Stok> secilen=new List<Entities.Tables.Stok>();
        public FrmStokSec(bool cokluSecim=false)
        {
            InitializeComponent();
            if(cokluSecim)
            {
                lblUyari.Visible = true;
                gridStoklar.OptionsSelection.MultiSelect = true;
            }
        }
        private void FrmStokSec_Load(object sender, EventArgs e)
        {
            gridContStoklar.DataSource = stokDal.GetAllJoin(context);
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            foreach (var row in gridStoklar.GetSelectedRows())
            {
                string stokkodu=gridStoklar.GetRowCellValue(row,colStokKodu).ToString();
                secilen.Add(context.Stoklar.SingleOrDefault(c => c.StokKodu == stokkodu));
            }
            this.Close();
        }
    }
}
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

namespace SonicHesap.BackOffice.Kasa
{
    public partial class FrmKasaSecim : DevExpress.XtraEditors.XtraForm
    {
        KasaDAL kasaDal=new KasaDAL();
        SonicHesapContext context = new SonicHesapContext();
        public Entities.Tables.Kasa entity=new Entities.Tables.Kasa();
        public bool secildi=false;
        public FrmKasaSecim()
        {
            InitializeComponent();
        }

        private void FrmKasaSecim_Load(object sender, EventArgs e)
        {
            gridContSecim.DataSource = kasaDal.KasaListele(context);
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            if (gridSecim.GetSelectedRows().Length!=0)
            {
                string kasaKodu = gridSecim.GetFocusedRowCellValue(colKasaKodu).ToString();
                entity = context.Kasalar.SingleOrDefault(c => c.KasaKodu == kasaKodu);
                entity.KasaAdi= gridSecim.GetFocusedRowCellValue(colKasaAdi).ToString();
                secildi = true;
                this.Close();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
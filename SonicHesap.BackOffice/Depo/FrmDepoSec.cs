using DevExpress.XtraEditors;
using SonicHesap.Entities.Context;
using SonicHesap.Entities.Data_Access;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SonicHesap.BackOffice.Depo
{
    public partial class FrmDepoSec : DevExpress.XtraEditors.XtraForm
    {
        SonicHesapContext context=new SonicHesapContext();
        DepoDAL depoDal=new DepoDAL();
        public Entities.Tables.Depo entity=new Entities.Tables.Depo();
        private string _stokKodu;
        public FrmDepoSec(string stokKodu)
        {
            InitializeComponent();
            _stokKodu = stokKodu;
        }

        private void FrmDepoSec_Load(object sender, EventArgs e)
        {
            gridContDepolar.DataSource = depoDal.DepoBazindaStokListele(context, _stokKodu);
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            string depoKodu=gridDepolar.GetFocusedRowCellValue(colDepoKodu).ToString();
            entity=context.Depolar.SingleOrDefault(c=>c.DepoKodu==depoKodu);
            this.Close();
        }
    }
}
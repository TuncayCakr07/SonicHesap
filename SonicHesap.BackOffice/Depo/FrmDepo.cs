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

namespace SonicHesap.BackOffice.Depo
{
    public partial class FrmDepo : DevExpress.XtraEditors.XtraForm
    {
        SonicHesapContext context=new SonicHesapContext();
        DepoDAL depoDal=new DepoDAL();
        public FrmDepo()
        {
            InitializeComponent();
        }

        private void FrmDepo_Load(object sender, EventArgs e)
        {
            Listele();
        }

        public void Listele()
        {
            gridContDepolar.DataSource = depoDal.GetAll(context);

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Both;
        }

        private void btnFormKapat_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2;
        }

        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            filterControl1.ApplyFilter();
        }

        private void btnFiltreKapat_Click(object sender, EventArgs e)
        {
            filterControl1.FilterString = null;
            filterControl1.ApplyFilter();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Veriyi Silmek İstediğinize Eminmisiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string secilen = gridDepolar.GetFocusedRowCellValue(colDepoKodu).ToString();
                depoDal.Delete(context, c => c.DepoKodu == secilen);
                depoDal.Save(context);
                Listele();
            }
        }
    }
}
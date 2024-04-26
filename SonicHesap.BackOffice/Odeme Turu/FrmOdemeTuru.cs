using DevExpress.XtraEditors;
using SonicHesap.BackOffice.Cari;
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

namespace SonicHesap.BackOffice.Odeme_Turu
{
    public partial class FrmOdemeTuru : DevExpress.XtraEditors.XtraForm
    {
        SonicHesapContext context=new SonicHesapContext();
        OdemeTuruDAL OdemeTuruDAL = new OdemeTuruDAL();
        int secilen;
        public FrmOdemeTuru()
        {
            InitializeComponent();
        }

        private void FrmOdemeTuru_Load(object sender, EventArgs e)
        {
            Listele();
        }
        public void Listele()
        {
            gridContOdemeTuru.DataSource = OdemeTuruDAL.OdemeTuruListele(context);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Both;
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

        private void btnFormKapat_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Veriyi Silmek İstediğinize Eminmisiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string secilen = gridOdemeTuru.GetFocusedRowCellValue(colOdemeTuruKodu).ToString();
                OdemeTuruDAL.Delete(context, c => c.OdemeTuruKodu == secilen);
                OdemeTuruDAL.Save(context);
                Listele();
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmOdemeTuruIslem form=new FrmOdemeTuruIslem(new Entities.Tables.OdemeTuru());
            form.ShowDialog();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            secilen = Convert.ToInt32(gridOdemeTuru.GetFocusedRowCellValue(colId));
            FrmOdemeTuruIslem form = new FrmOdemeTuruIslem(OdemeTuruDAL.GetByFilter(context,c=>c.Id==secilen));
            form.ShowDialog();
        }

        private void btnHareket_Click(object sender, EventArgs e)
        {
            secilen = Convert.ToInt32(gridOdemeTuru.GetFocusedRowCellValue(colId));
            FrmCariHareket form = new FrmCariHareket(secilen);
            form.ShowDialog();
            Listele();
        }
    }
}
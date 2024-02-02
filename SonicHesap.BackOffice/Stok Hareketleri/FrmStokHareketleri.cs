using DevExpress.XtraEditors;
using SonicHesap.BackOffice.Fis;
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

namespace SonicHesap.BackOffice.Stok_Hareketleri
{
    public partial class FrmStokHareketleri : DevExpress.XtraEditors.XtraForm
    {
        SonicHesapContext contex =new SonicHesapContext();
        StokHareketDAL StokHareketDal = new StokHareketDAL();
        public FrmStokHareketleri()
        {
            InitializeComponent();
        }

        private void Listele()
        {
            gridContStokHareket.DataSource=StokHareketDal.GetAll(contex);
        }

        private void FrmStokHareketleri_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Both;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void repoSeriNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string veri = Convert.ToString(gridStokHareket.GetFocusedRowCellValue(colSeriNo));
            FrmSeriNoGir form = new FrmSeriNoGir(veri);
            form.kilitli = true;
            form.ShowDialog();
        }

        private void btnDetayGor_Click(object sender, EventArgs e)
        {
            FrmFisIslem form = new FrmFisIslem(gridStokHareket.GetFocusedRowCellValue(ColFisKodu).ToString());
            form.ShowDialog();
        }
    }
}
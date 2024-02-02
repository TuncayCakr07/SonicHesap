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

namespace SonicHesap.BackOffice.Kasa_Hareketleri
{
    public partial class FrmKasaHareketleri : DevExpress.XtraEditors.XtraForm
    {
        SonicHesapContext context = new SonicHesapContext();
        KasaHareketDAL kasaHareketDal= new KasaHareketDAL();
        public FrmKasaHareketleri()
        {
            InitializeComponent();
        }

        private void Listele()
        {
            gridContKasaHareket.DataSource = kasaHareketDal.GetAll(context);
        }

        private void FrmKasaHareketleri_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnDetayGor_Click(object sender, EventArgs e)
        {
            FrmFisIslem form=new FrmFisIslem(gridKasaHareket.GetFocusedRowCellValue(colFisKodu).ToString());
            form.ShowDialog();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Both;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
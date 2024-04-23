using DevExpress.XtraEditors;
using SonicHesap.Entities.Context;
using SonicHesap.Entities.Data_Access;
using SonicHesap.Entities.Tools;
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
    public partial class FrmStok : DevExpress.XtraEditors.XtraForm
    {
        SonicHesapContext context=new SonicHesapContext();
        StokDAL StokDAL = new StokDAL();
        string secilen;
        public FrmStok()
        {
            InitializeComponent();
            RoleTool.RooleriYukle(this);
        }

        private void FrmStok_Load(object sender, EventArgs e)
        {
            GetAll();
        }
        public void GetAll() 
        {
            gridControl1.DataSource = StokDAL.StokListele(context);
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

        private void btnAra_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Both;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            GetAll();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Veriyi Silmek İstediğinize Eminmisiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==DialogResult.Yes)
            {
                secilen = gridView1.GetFocusedRowCellValue(colStokKodu).ToString();
                StokDAL.Delete(context,c=>c.StokKodu==secilen);
                StokDAL.Save(context);
                GetAll();
            }
            
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmStokIslem form=new FrmStokIslem(new Entities.Tables.Stok());
            form.ShowDialog();
            if (form.saved)
            {
                GetAll();
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
             secilen = gridView1.GetFocusedRowCellValue(colStokKodu).ToString();
            FrmStokIslem form = new FrmStokIslem(StokDAL.GetByFilter(context,c=>c.StokKodu==secilen));
            form.ShowDialog();
            if (form.saved)
            {
                GetAll();
            }
        }

        private void btnKopyala_Click(object sender, EventArgs e)
        {
             secilen = gridView1.GetFocusedRowCellValue(colStokKodu).ToString();
            Entities.Tables.Stok stokEntity= new Entities.Tables.Stok();
            stokEntity = StokDAL.GetByFilter(context, c => c.StokKodu == secilen);
            stokEntity.Id = -1;
            stokEntity.StokKodu = null;
            FrmStokIslem form = new FrmStokIslem(stokEntity);
            form.ShowDialog();
            if (form.saved)
            {
                GetAll();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
             secilen = gridView1.GetFocusedRowCellValue(colStokKodu).ToString();
            string secilenAd = gridView1.GetFocusedRowCellValue(colStokAdi).ToString();
            FrmStokHareket form = new FrmStokHareket(secilen,secilenAd);
            form.ShowDialog();
        }
    }
}
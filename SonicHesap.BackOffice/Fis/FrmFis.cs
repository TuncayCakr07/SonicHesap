﻿using DevExpress.XtraEditors;
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

namespace SonicHesap.BackOffice.Fis
{
    
    public partial class FrmFis : DevExpress.XtraEditors.XtraForm
    {
        SonicHesapContext context = new SonicHesapContext();
        FisDAL fisDal = new FisDAL();
        KasaHareketDAL kasaHareketDal = new KasaHareketDAL();
        StokHareketDAL stokHareketDal = new StokHareketDAL();
        public FrmFis()
        {
            InitializeComponent();
        }

        private void FrmFis_Load(object sender, EventArgs e)
        {
            Listele();
        }
        void Listele()
        {
            gridContFis.DataSource=fisDal.GetAll(context);
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
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2;
        }

        private void btnFormKapat_Click(object sender, EventArgs e)
        {
            filterControl1.FilterString = null;
            filterControl1.ApplyFilter();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Veriyi Silmek İstediğinize Eminmisiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string secilen = gridFis.GetFocusedRowCellValue(colFisKodu).ToString();
                fisDal.Delete(context, c => c.FisKodu == secilen);
                kasaHareketDal.Delete(context, c => c.FisKodu == secilen);
                stokHareketDal.Delete(context, c => c.FisKodu == secilen);
                fisDal.Save(context);
                MessageBox.Show("Seçili Olan Veri Silindi!", "Bilgi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
            }
        }
    }
}
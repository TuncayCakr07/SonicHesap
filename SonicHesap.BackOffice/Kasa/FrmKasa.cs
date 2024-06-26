﻿using DevExpress.XtraEditors;
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

namespace SonicHesap.BackOffice.Kasa
{
    public partial class FrmKasa : DevExpress.XtraEditors.XtraForm
    {
        KasaDAL kasaDAL=new KasaDAL();
        SonicHesapContext context=new SonicHesapContext();
        int secilen;
        public FrmKasa()
        {
            InitializeComponent();
        }

        public void Guncelle()
        {
            gridContKasalar.DataSource=kasaDAL.KasaListele(context);
        }

        private void FrmKasa_Load(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2;
            Guncelle();
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

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmKasaIslem form=new FrmKasaIslem(new Entities.Tables.Kasa());
            form.ShowDialog();
            if (form.Kaydedildi)
            {
                Guncelle();
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            secilen = Convert.ToInt32(gridKasalar.GetFocusedRowCellValue(colId));
            FrmKasaIslem form = new FrmKasaIslem(kasaDAL.GetByFilter(context, c => c.Id == secilen));
            form.ShowDialog();
            if (form.Kaydedildi)
            {
                Guncelle();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Veriyi Silmek İstediğinize Eminmisiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                secilen = Convert.ToInt32(gridKasalar.GetFocusedRowCellValue(colId));
                kasaDAL.Delete(context, c => c.Id == secilen);
                kasaDAL.Save(context);
                Guncelle();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            secilen = Convert.ToInt32(gridKasalar.GetFocusedRowCellValue(colId));
            string secilenAd = gridKasalar.GetFocusedRowCellValue(colKasaKodu).ToString();
            FrmCariHareket form = new FrmCariHareket(secilen);
            form.ShowDialog();
            Guncelle();
        }
    }
}
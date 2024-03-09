﻿using DevExpress.XtraReports.UI;
using SonicHesap.BackOffice.Ajanda;
using SonicHesap.BackOffice.AnaMenu;
using SonicHesap.BackOffice.Ayarlar;
using SonicHesap.BackOffice.Cari;
using SonicHesap.BackOffice.Depo;
using SonicHesap.BackOffice.Doviz_Kurlari;
using SonicHesap.BackOffice.Email;
using SonicHesap.BackOffice.Fis;
using SonicHesap.BackOffice.Fiyat_Degistir;
using SonicHesap.BackOffice.Indirim;
using SonicHesap.BackOffice.Kasa;
using SonicHesap.BackOffice.Kasa_Hareketleri;
using SonicHesap.BackOffice.Odeme_Turu;
using SonicHesap.BackOffice.Personel;
using SonicHesap.BackOffice.Raporlar;
using SonicHesap.BackOffice.Stok;
using SonicHesap.BackOffice.Stok_Hareketleri;
using SonicHesap.BackOffice.Tanimlar;
using SonicHesap.Backup;
using SonicHesap.Entities.Context;
using SonicHesap.Report.Fatura_Ve_Fiş;
using SonicHesap.Report.Stok;
using SonicHesap.Update;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SonicHesap.BackOffice
{
    public partial class FrmAnaMenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmAnaMenu()
        {
            InitializeComponent();
            using (var context = new SonicHesapContext())
            {
                context.Database.CreateIfNotExists();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmStok form = new FrmStok();
            form.MdiParent = this;
            form.Show();
        }

        private void btnCari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmCari form = new FrmCari();
            form.MdiParent = this;
            form.Show();
        }

        private void btnKasa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmKasa form = new FrmKasa();
            form.MdiParent = this;
            form.Show();
        }

        private void btnDepo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDepo form = new FrmDepo();
            form.MdiParent = this;
            form.Show();
        }

        private void btnOdemeTuru_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmOdemeTuru form = new FrmOdemeTuru();
            form.MdiParent = this;
            form.Show();
        }

        private void btnTanim_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnFis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmFis form = new FrmFis();
            form.MdiParent = this;
            form.Show();
        }

        private void btnFisIslem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmFisIslem form = new FrmFisIslem();
            form.Show();
        }

        private void FrmAnaMenu_Load(object sender, EventArgs e)
        {
            FrmAnaMenuBilgi form = new FrmAnaMenuBilgi();
            form.MdiParent = this;
            form.Show();
        }

        private void btnStokHareketleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmStokHareketleri form = new FrmStokHareketleri();
            form.MdiParent = this;
            form.Show();
        }

        private void btnKasaHareket_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmKasaHareketleri form = new FrmKasaHareketleri();
            form.MdiParent = this;
            form.Show();
        }

        private void btnPersoneller_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmPersonel form = new FrmPersonel();
            form.MdiParent = this;
            form.Show();
        }

        private void btnFaturaVeFis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmFis form = new FrmFis();
            form.MdiParent = this;
            form.Show();
        }

        private void FisIslem_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmFisIslem form = new FrmFisIslem(null, e.Item.Caption);
            form.ShowDialog();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmTopluFiyat form = new FrmTopluFiyat();
            form.MdiParent = this;
            form.Show();
        }

        private void btnIndirim_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmIndirimislemleri form = new FrmIndirimislemleri();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            rptFatura report = new rptFatura("7");
            FrmRaporGoruntuleme form = new FrmRaporGoruntuleme(report);
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmRaporListesi form = new FrmRaporListesi();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmRaporDuzenle form = new FrmRaporDuzenle();
            form.WindowState=FormWindowState.Maximized;
            form.Show();
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmEtiketOlustur form = new FrmEtiketOlustur();
            form.ShowDialog();
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmOzgunRaporHazirla form = new FrmOzgunRaporHazirla();
            form.ShowDialog();
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmAjanda form = new FrmAjanda();
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmEmail form=new FrmEmail();
            form.Show();
        }

        private void barButtonItem28_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDovizKurlari form = new FrmDovizKurlari();
            form.ShowDialog();
        }

        private void barButtonItem29_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmAyarlar form = new FrmAyarlar();
            form.ShowDialog();
        }

        private void barButtonItem30_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmBackup form = new FrmBackup();
            try
            {
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Form açılırken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void barButtonItem31_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Process.Start($"{Application.StartupPath}\\SonicHesap.Update.exe");
        }
    }
}

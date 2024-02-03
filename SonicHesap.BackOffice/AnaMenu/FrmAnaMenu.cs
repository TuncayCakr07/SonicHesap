using SonicHesap.BackOffice.AnaMenu;
using SonicHesap.BackOffice.Cari;
using SonicHesap.BackOffice.Depo;
using SonicHesap.BackOffice.Fis;
using SonicHesap.BackOffice.Kasa;
using SonicHesap.BackOffice.Kasa_Hareketleri;
using SonicHesap.BackOffice.Odeme_Turu;
using SonicHesap.BackOffice.Personel;
using SonicHesap.BackOffice.Stok;
using SonicHesap.BackOffice.Stok_Hareketleri;
using SonicHesap.BackOffice.Tanimlar;
using SonicHesap.Entities.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            using (var context=new SonicHesapContext())
            {
                context.Database.CreateIfNotExists();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmStok form=new FrmStok();
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
    }
}

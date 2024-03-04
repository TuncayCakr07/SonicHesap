using DevExpress.XtraEditors;
using SonicHesap.BackOffice.Cari;
using SonicHesap.BackOffice.Depo;
using SonicHesap.BackOffice.Fis;
using SonicHesap.BackOffice.Kasa;
using SonicHesap.BackOffice.Odeme_Turu;
using SonicHesap.BackOffice.Personel;
using SonicHesap.BackOffice.Raporlar;
using SonicHesap.BackOffice.Stok;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SonicHesap.BackOffice.AnaMenu
{
    public partial class FrmAnaMenuBilgi : DevExpress.XtraEditors.XtraForm
    {
        public FrmAnaMenuBilgi()
        {
            InitializeComponent();
        }

        private void tileItem1_ItemClick(object sender, TileItemEventArgs e)
        {
            FrmStok form = new FrmStok();
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void tileCariler_ItemClick(object sender, TileItemEventArgs e)
        {
            FrmCari form = new FrmCari();
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void tileDepolar_ItemClick(object sender, TileItemEventArgs e)
        {
            FrmDepo form = new FrmDepo();
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void tileKasalar_ItemClick(object sender, TileItemEventArgs e)
        {
            FrmKasa form = new FrmKasa();
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void tileFaturaVeFis_ItemClick(object sender, TileItemEventArgs e)
        {
            FrmFis form = new FrmFis();
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void tileOdemeTurleri_ItemClick(object sender, TileItemEventArgs e)
        {
            FrmOdemeTuru form = new FrmOdemeTuru();
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void tileRaporlar_ItemClick(object sender, TileItemEventArgs e)
        {
            FrmRaporListesi form = new FrmRaporListesi();
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void tileRaporOlustur_ItemClick(object sender, TileItemEventArgs e)
        {
            FrmRaporDuzenle form = new FrmRaporDuzenle();
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void tileEtiketOlustur_ItemClick(object sender, TileItemEventArgs e)
        {
            FrmEtiketOlustur form = new FrmEtiketOlustur();
            form.ShowDialog();
        }

        private void tileOzgunRapor_ItemClick(object sender, TileItemEventArgs e)
        {
            FrmOzgunRaporHazirla form = new FrmOzgunRaporHazirla();
            form.ShowDialog();
        }

        private void tilePersonel_ItemClick(object sender, TileItemEventArgs e)
        {
            FrmPersonel form = new FrmPersonel();
            form.MdiParent = this;
            form.Show();
        }

        private void tileAlimFaturasi_ItemClick(object sender, TileItemEventArgs e)
        {
            FrmFisIslem form = new FrmFisIslem(e.Item.Text);
            form.ShowDialog();
        }

        private void tilePerakendeSatis_ItemClick(object sender, TileItemEventArgs e)
        {
            FrmFisIslem form = new FrmFisIslem(null, e.Item.Text);
            form.ShowDialog();
        }

        private void tileToptanSatis_ItemClick(object sender, TileItemEventArgs e)
        {
            FrmFisIslem form = new FrmFisIslem(null, e.Item.Text);
            form.ShowDialog();
        }

        private void tileAlimIade_ItemClick(object sender, TileItemEventArgs e)
        {
            FrmFisIslem form = new FrmFisIslem(null, e.Item.Text);
            form.ShowDialog();
        }

        private void tilePerakendeSatisIade_ItemClick(object sender, TileItemEventArgs e)
        {
            FrmFisIslem form = new FrmFisIslem(null, e.Item.Text);
            form.ShowDialog();
        }

        private void tileTahsilatFisi_ItemClick(object sender, TileItemEventArgs e)
        {
            FrmFisIslem form = new FrmFisIslem(null, e.Item.Text);
            form.ShowDialog();
        }

        private void tileOdemeFisi_ItemClick(object sender, TileItemEventArgs e)
        {
            FrmFisIslem form = new FrmFisIslem(null, e.Item.Text);
            form.ShowDialog();
        }

        private void tileCariDevirFisi_ItemClick(object sender, TileItemEventArgs e)
        {
            FrmFisIslem form = new FrmFisIslem(null, e.Item.Text);
            form.ShowDialog();
        }

        private void tileStokDevirfisi_ItemClick(object sender, TileItemEventArgs e)
        {
            FrmFisIslem form = new FrmFisIslem(null, e.Item.Text);
            form.ShowDialog();
        }

        private void tileSayimFazlasi_ItemClick(object sender, TileItemEventArgs e)
        {
            FrmFisIslem form = new FrmFisIslem(null, e.Item.Text);
            form.ShowDialog();
        }

        private void tileSayimEksigi_ItemClick(object sender, TileItemEventArgs e)
        {
            FrmFisIslem form = new FrmFisIslem(null, e.Item.Text);
            form.ShowDialog();
        }
    }
}
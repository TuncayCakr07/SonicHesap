using DevExpress.XtraEditors;
using SonicHesap.BackOffice.Cari;
using SonicHesap.BackOffice.Stok;
using SonicHesap.Entities.Context;
using SonicHesap.Entities.Data_Access;
using SonicHesap.Entities.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SonicHesap.BackOffice.Fis
{
    public partial class FrmFisIslem : DevExpress.XtraEditors.XtraForm
    {
        SonicHesapContext contex = new SonicHesapContext();
        FisDAL fisDal = new FisDAL();
        StokHareketDAL stokHareketDal = new StokHareketDAL();
        KasaHareketDAL kasaHareketDal = new KasaHareketDAL();
        Entities.Tables.Fis _fisEntity = new Entities.Tables.Fis();
        public FrmFisIslem()
        {
            InitializeComponent();
            txtFisTuru.DataBindings.Add("Text", _fisEntity, "FisTuru");
            cmbTarih.DataBindings.Add("EditValue", _fisEntity, "Tarih");
            txtBelgeNo.DataBindings.Add("Text", _fisEntity, "BelgeNo");
            txtAciklama.DataBindings.Add("Text", _fisEntity, "Aciklama");
            lblCariKodu.DataBindings.Add("Text", _fisEntity, "CariKodu");
            lblCariAdi.DataBindings.Add("Text", _fisEntity, "CariAdi");
            gridContStokHareket.DataSource = contex.StokHareketleri.Local.ToBindingList();
            gridContKasaHareket.DataSource = contex.KasaHareketleri.Local.ToBindingList();
        }

        private void FrmFisIslem_Load(object sender, EventArgs e)
        {

        }
        private StokHareket StokSec(Entities.Tables.Stok entity)
        {
            StokHareket stokHareket = new StokHareket();
            stokHareket.StokKodu = entity.StokKodu;
            stokHareket.StokAdi = entity.StokAdi;
            stokHareket.Barkod = entity.Barkod;
            stokHareket.BarkodTuru = entity.BarkodTuru;
            stokHareket.BirimFiyati = entity.SatisFiyati1;
            stokHareket.Birimi = entity.Birimi;
            stokHareket.Miktar = txtMiktar.Value;
            stokHareket.Kdv = entity.SatisKdv;
            return stokHareket;
        }

        private void btnStokSec_Click(object sender, EventArgs e)
        {
            FrmStokSec form = new FrmStokSec();
            form.ShowDialog();
            if (form.secildi)
            {
                stokHareketDal.AddOrUpdate(contex, StokSec(form.secilen.First()));
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Entities.Tables.Stok entity;
                entity = contex.Stoklar.Where(c => c.Barkod == txtBarkod.Text).SingleOrDefault();
                if (entity != null)
                {
                    stokHareketDal.AddOrUpdate(contex, StokSec(entity));
                }
                else
                {
                    MessageBox.Show("Aradığınız Barkod Numarasına Ait Ürün Bulunamadı!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtBarkod.Text = null;
                txtMiktar.Text = null;
                txtBarkod.Focus();
            }
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            FrmCariSec form= new FrmCariSec();
            form.ShowDialog();
            if (form.secildi)
            {
                Entities.Tables.Cari entity= form.secilen.FirstOrDefault();
                CariBakiye bakiye=form.secilenCariBakiye.FirstOrDefault();

                lblCariKodu.Text =entity.CariKodu;
                lblCariAdi.Text = entity.CariAdi;
                txtFaturaUnvani.Text= entity.FaturaUnvani;
                txtVergiDairesi.Text= entity.VergiDairesi;
                txtVergiNo.Text= entity.VergiNo;
                txtCepTelefonu.Text= entity.CepTelefonu;
                txtIl.Text= entity.Il;
                txtIlce.Text= entity.Ilce;
                txtSemt.Text= entity.Semt;
                txtAdres.Text= entity.Adres;
                lblAlacak.Text=bakiye.Alacak.ToString("C2");
                lblBorc.Text = bakiye.Borc.ToString("C2");
                lblBakiye.Text = bakiye.Bakiye.ToString("C2");
            }
        }
    }
}
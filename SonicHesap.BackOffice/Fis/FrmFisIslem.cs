using DevExpress.XtraEditors;
using SonicHesap.BackOffice.Cari;
using SonicHesap.BackOffice.Depo;
using SonicHesap.BackOffice.Stok;
using SonicHesap.Entities.Context;
using SonicHesap.Entities.Data_Access;
using SonicHesap.Entities.Interfaces;
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
        CariDAL cariDal= new CariDAL();
        Entities.Tables.Fis _fisEntity = new Entities.Tables.Fis();
        CariBakiye entityBakiye = new CariBakiye();
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
            stokHareket.IndirimOrani = 0;
            return stokHareket;
        }

        private void btnStokSec_Click(object sender, EventArgs e)
        {
            FrmStokSec form = new FrmStokSec();
            form.ShowDialog();
            if (form.secildi)
            {
                stokHareketDal.AddOrUpdate(contex, StokSec(form.secilen.First()));
                Toplamlar();
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
                    Toplamlar();
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
                entityBakiye = cariDal.CariBakiyesi(contex, entity.CariKodu);

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
                lblAlacak.Text=entityBakiye.Alacak.ToString("C2");
                lblBorc.Text = entityBakiye.Borc.ToString("C2");
                lblBakiye.Text = entityBakiye.Bakiye.ToString("C2");
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            lblCariKodu.Text =null;
            lblCariAdi.Text = null;
            txtFaturaUnvani.Text = null;
            txtVergiDairesi.Text = null;
            txtVergiNo.Text = null;
            txtCepTelefonu.Text = null;
            txtIl.Text = null;
            txtIlce.Text = null;
            txtSemt.Text = null;
            txtAdres.Text = null;
            lblAlacak.Text = "Görüntülenemiyor";
            lblBorc.Text = "Görüntülenemiyor";
            lblBakiye.Text = "Görüntülenemiyor";
        }

        private void gridStokHareket_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
                Toplamlar();
        }

        private void Toplamlar()
        {
            gridStokHareket.UpdateSummary();
            txtIskontoTutar.Value = Convert.ToDecimal(colToplamTutar.SummaryItem.SummaryValue) / 100 * txtIskontoOrani.Value;
            txtToplam.Value = Convert.ToDecimal(colToplamTutar.SummaryItem.SummaryValue) - txtIskontoTutar.Value;
            txtKdvToplam.Value = Convert.ToDecimal(colKdvToplam.SummaryItem.SummaryValue);
            txtIndirimToplam.Value = Convert.ToDecimal(colIndirimtutari.SummaryItem.SummaryValue);

        }

        private void txtToplam_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void txtIskontoOrani_EditValueChanged(object sender, EventArgs e)
        {
           
        }

        private void txtIskontoOrani_Validated(object sender, EventArgs e)
        {
            Toplamlar();
        }

        private void repoDepoSecim_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FrmDepoSec form=new FrmDepoSec(gridStokHareket.GetFocusedRowCellValue(colStokKodu).ToString());
            form.ShowDialog();
            if (form.secildi)
            {
                gridStokHareket.SetFocusedRowCellValue(colDepoKodu, form.entity.DepoKodu);
                gridStokHareket.SetFocusedRowCellValue(colDepoAdi, form.entity.DepoAdi);
            }
        }

        private void repoBirimFiyat_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string fiyatSecilen=gridStokHareket.GetFocusedRowCellValue(colStokKodu).ToString(); 
            Entities.Tables.Stok fiyatEntity=contex.Stoklar.Where(c=>c.StokKodu==fiyatSecilen).SingleOrDefault();

            barFiyat1.Tag = fiyatEntity.SatisFiyati1 ?? 0;
            barFiyat2.Tag = fiyatEntity.SatisFiyati2 ?? 0;
            barFiyat3.Tag = fiyatEntity.SatisFiyati3 ?? 0;
            barFiyat1.Caption = string.Format("{0:C2}",barFiyat1.Tag);
            barFiyat2.Caption = string.Format("{0:C2}",barFiyat2.Tag);
            barFiyat3.Caption = string.Format("{0:C2}",barFiyat3.Tag);
            radialFiyat.ShowPopup(MousePosition);
        }

        private void FiyatSec(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridStokHareket.SetFocusedRowCellValue(colBirimFiyati,Convert.ToDecimal(e.Item.Tag));
        }
    }
}
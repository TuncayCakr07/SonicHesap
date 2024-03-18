using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using SonicHesap.BackOffice.Cari;
using SonicHesap.BackOffice.Depo;
using SonicHesap.BackOffice.Fis;
using SonicHesap.BackOffice.Stok;
using SonicHesap.Entities.Context;
using SonicHesap.Entities.Data_Access;
using SonicHesap.Entities.Tables;
using SonicHesap.Entities.Tables.OtherTables;
using SonicHesap.Entities.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SonicHesap.FrontOffice
{
    public partial class FrmFrontOffice : DevExpress.XtraEditors.XtraForm
    {
        Entities.Tables.Fis _fisEntity = new Entities.Tables.Fis();
        FisAyarlari ayarlar = new FisAyarlari();
        CariDAL cariDal = new CariDAL();
        SonicHesapContext context = new SonicHesapContext();
        CariBakiye entityBakiye = new CariBakiye();
        FisDAL fisDal = new FisDAL();
        KasaHareketDAL kasaHareketDal = new KasaHareketDAL();
        StokHareketDAL stokHareketDal = new StokHareketDAL();

        public FrmFrontOffice()
        {
            InitializeComponent();
            gridContStokHareket.DataSource = context.StokHareketleri.Local.ToBindingList();
            txtFisKodu.DataBindings.Add("Text", _fisEntity, "FisKodu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtBelgeNo.DataBindings.Add("Text", _fisEntity, "BelgeNo", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAciklama.DataBindings.Add("Text", _fisEntity, "Aciklama", false, DataSourceUpdateMode.OnPropertyChanged);
            txtCariKodu.DataBindings.Add("Text", _fisEntity, "CariKodu", false, DataSourceUpdateMode.OnPropertyChanged, null);
            txtCariAdi.DataBindings.Add("Text", _fisEntity, "CariAdi", false, DataSourceUpdateMode.OnPropertyChanged, null);
            txtFaturaUnvani.DataBindings.Add("Text", _fisEntity, "FaturaUnvani", false, DataSourceUpdateMode.OnPropertyChanged);
            txtCepTelefonu.DataBindings.Add("Text", _fisEntity, "CepTelefonu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtIl.DataBindings.Add("Text", _fisEntity, "Il", false, DataSourceUpdateMode.OnPropertyChanged);
            txtIlce.DataBindings.Add("Text", _fisEntity, "Ilce", false, DataSourceUpdateMode.OnPropertyChanged);
            txtSemt.DataBindings.Add("Text", _fisEntity, "Semt", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAdres.DataBindings.Add("Text", _fisEntity, "Adres", false, DataSourceUpdateMode.OnPropertyChanged);
            txtVergiDairesi.DataBindings.Add("Text", _fisEntity, "VergiDairesi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtVergiNo.DataBindings.Add("Text", _fisEntity, "VergiNo", false, DataSourceUpdateMode.OnPropertyChanged);
            ButonlariYukle();
            txtIslem.Text = "SATIŞ";
            this.WindowState = FormWindowState.Maximized;
        }
        private void HizliSatis_Click(object sender, EventArgs e)
        {
            var buton = sender as SimpleButton;
            Stok entity = new Stok();
            entity = context.Stoklar.SingleOrDefault(c => c.Barkod == buton.Name);
            if (entity != null)
            {
                stokHareketDal.AddOrUpdate(context, StokSec(entity));
                Toplamlar();
            }
            else
            {
                MessageBox.Show("Aradığınız Barkod Numarasına Ait Ürün Bulunamadı!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtMiktar.Value = 1;
        }
        private void ButonlariYukle()
        {

            foreach (var hizliSatisGrup in context.HizliSatisGruplari.ToList())
            {
                XtraTabPage page = new XtraTabPage { Name = hizliSatisGrup.Id.ToString(), Text = hizliSatisGrup.GrupAdi };
                FlowLayoutPanel panel = new FlowLayoutPanel();
                panel.Dock = DockStyle.Fill;
                page.Controls.Add(panel);
                foreach (var hizliSatis in context.HizliSatislar.Where(c => c.GrupId == hizliSatisGrup.Id).ToList())
                {
                    SimpleButton buton = new SimpleButton
                    {
                        Name = hizliSatis.Barkod,
                        Text = hizliSatis.UrunAdi,
                        Height = 150,
                        Width = 150,
                    };
                    buton.Click += HizliSatis_Click;
                    panel.Controls.Add(buton);
                }
                xtraTabControl1.TabPages.Add(page);
            }

            foreach (var item in context.OdemeTurleri.ToList())
            {
                var buton = new SimpleButton
                {
                    Name = item.OdemeTuruKodu,
                    Text = item.OdemeTuruAdi,
                    Height = 55,
                    Width = 110,
                };
                buton.Click += OdemeEkle_Click;
                flowOdemeTurleri.Controls.Add(buton);
            }



            var SecimTemizle = new CheckButton
            {
                Name = "Temizle",
                Text = "Temizle",
                GroupIndex = 1,
                Height = 70,
                Width = 150,
                Checked = true,
            };
            SecimTemizle.Click += PersonelEkle_Click;
            flowPersonel.Controls.Add(SecimTemizle);

            foreach (var item in context.Personeller.ToList())
            {
                var buton = new CheckButton
                {
                    Name = item.PersonelKodu,
                    Text = item.PersonelAdi,
                    GroupIndex = 1,
                    Height = 70,
                    Width = 150,
                    Checked = false,
                };
                buton.Click += PersonelEkle_Click;
                flowPersonel.Controls.Add(buton);
            }
        }

        private void PersonelEkle_Click(object sender, EventArgs e)
        {

            var buton = sender as CheckButton;
            if (buton.Name == "Temizle")
            {
                _fisEntity.PlasiyerKodu = null;
                _fisEntity.PlasiyerAdi = null;
            }
            else
            {
                _fisEntity.PlasiyerKodu = buton.Name;
                _fisEntity.PlasiyerAdi = buton.Text;
            }

        }
        private void OdemeEkle_Click(object sender, EventArgs e)
        {
            var buton = (sender as SimpleButton);
            string kasaKodu = SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_VarsayilanKasa);
            _fisEntity.FisTuru = txtIslem.Text == "İADE" ? "Satış İade Faturası" : "Perakende Satış Faturası";
            kasaHareketDal.AddOrUpdate(context, new KasaHareket
            {
                CariKodu = txtCariKodu.Text,
                CariAdi = txtCariAdi.Text,
                FisKodu = txtFisKodu.Text,
                Hareket = txtIslem.Text == "İADE" ? "Kasa Çıkış" : "Kasa Giriş",
                KasaKodu = kasaKodu,
                KasaAdi = context.Kasalar.SingleOrDefault(x => x.KasaKodu == kasaKodu).KasaAdi,
                OdemeTuruKodu = buton.Name,
                OdemeTuruAdi = buton.Text,
                Tarih=DateTime.Now,
                Tutar=txtToplam.Value,
            });

            foreach (var stokVeri in context.StokHareketleri.Local.ToList())
            {
                stokVeri.Tarih = DateTime.Now;
                stokVeri.FisKodu = txtFisKodu.Text;
                stokVeri.Hareket = txtIslem.Text == "İADE" ? "Stok Giriş" : "Stok Çıkış";
            }
            _fisEntity.ToplamTutar = txtToplam.Value;
            _fisEntity.IskontoOrani = txtIskontoOrani.Value;
            _fisEntity.IskontoTutar = txtIskontoTutar.Value;
            _fisEntity.Tarih = DateTime.Now;
            fisDal.AddOrUpdate(context,_fisEntity);
            context.SaveChanges();
            //if (ayarlar.SatisEkrani == false)
            //{
            //    FrmOdemeEkrani form = new FrmOdemeEkrani(buton.Text, buton.Name);
            //    form.ShowDialog();
            //    if (form.entity != null)
            //    {
            //        // Ödeme türü adını da ekleyin
            //        form.entity.OdemeTuruAdi = buton.Text;
            //        kasaHareketDal.AddOrUpdate(context, form.entity);
            //        OdenenTutarGuncelle();
            //    }
            //}
            //else
            //{
            //    string odemeTuruKodu = buton.Name;
            //    string odemeTuruAdi = buton.Text;

            //    if (string.IsNullOrEmpty(odemeTuruKodu) || string.IsNullOrEmpty(odemeTuruAdi))
            //    {
            //        MessageBox.Show("Ödeme Türü ve Adı Boş Olamaz!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return;
            //    }

            //    KasaHareket entitykasaHareket = new KasaHareket
            //    {
            //        OdemeTuruKodu = odemeTuruKodu,
            //        OdemeTuruAdi = odemeTuruAdi,
            //        Tutar = txtOdenmesiGereken.Value
            //    };
            //    if (txtOdenmesiGereken.Value <= 0)
            //    {
            //        MessageBox.Show("Ödeme Yapılacak Tutar Bulunamadı!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //    else
            //    {
            //        kasaHareketDal.AddOrUpdate(context, entitykasaHareket);
            //        OdenenTutarGuncelle();
            //    }
            //}
        }

        //private void OdenenTutarGuncelle()
        //{
        //    gridKasaHareket.UpdateSummary();
        //    if (ayarlar.SatisEkrani)
        //    {
        //        txtOdenenTutar.Value = Convert.ToDecimal(colTutar.SummaryItem.SummaryValue);
        //        txtOdenmesiGereken.Value = txtToplam.Value - txtOdenenTutar.Value;
        //    }
        //    else
        //    {
        //        txtToplam.Value = Convert.ToDecimal(colTutar.SummaryItem.SummaryValue);
        //    }

        //}

        private void btnStokSec_Click(object sender, EventArgs e)
        {
            FrmStokSec form = new FrmStokSec();
            form.ShowDialog();
            if (form.secildi)
            {
                stokHareketDal.AddOrUpdate(context, StokSec(form.secilen.First()));
                Toplamlar();
            }
        }

        private StokHareket StokSec(Entities.Tables.Stok entity)
        {
            StokHareket stokHareket = new StokHareket();
            IndirimDAL indirimDal = new IndirimDAL();
            stokHareket.StokKodu = entity.StokKodu;
            stokHareket.StokAdi = entity.StokAdi;
            stokHareket.Barkod = entity.Barkod;
            stokHareket.IndirimOrani = indirimDal.StokIndirimi(context, entity.StokKodu);
            stokHareket.DepoKodu = SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_VarsayilanDepo);
            stokHareket.DepoAdi = context.Depolar.SingleOrDefault(x => x.DepoKodu == stokHareket.DepoKodu).DepoAdi;
            stokHareket.BarkodTuru = entity.BarkodTuru;
            stokHareket.BirimFiyati = _fisEntity.FisTuru == "Alış Faturası" ? entity.AlisFiyati1 : entity.SatisFiyati1;
            stokHareket.Birimi = entity.Birimi;
            stokHareket.Miktar = txtMiktar.Value;
            stokHareket.Kdv = entity.SatisKdv;
            stokHareket.Tarih = DateTime.Now;
            return stokHareket;
        }
        private void Toplamlar()
        {
            gridStokHareket.UpdateSummary();
            txtIskontoTutar.Value = Convert.ToDecimal(colToplamTutar.SummaryItem.SummaryValue) / 100 * txtIskontoOrani.Value;
            txtToplam.Value = Convert.ToDecimal(colToplamTutar.SummaryItem.SummaryValue) - txtIskontoTutar.Value;
            txtKDVToplam.Value = Convert.ToDecimal(colKdvToplam.SummaryItem.SummaryValue);
            txtIndirimToplam.Value = Convert.ToDecimal(colIndirimtutari.SummaryItem.SummaryValue);
            txtParaUstu.Value = txtOdenenTutar.Value - txtToplam.Value;
            txtAraToplam.Value = txtToplam.Value - txtKDVToplam.Value;
        }

        private void simpleButton13_Click(object sender, EventArgs e)
        {

        }

        private void btnBul_Click(object sender, EventArgs e)
        {

            FrmCariSec form = new FrmCariSec();
            form.ShowDialog();
            if (form.secildi)
            {
                Entities.Tables.Cari entity = form.secilen.FirstOrDefault();
                entityBakiye = cariDal.CariBakiyesi(context, entity.CariKodu);

                txtCariKodu.Text = entity.CariKodu;
                txtCariAdi.Text = entity.CariAdi;
                txtFaturaUnvani.Text = entity.FaturaUnvani;
                txtVergiDairesi.Text = entity.VergiDairesi;
                txtVergiNo.Text = entity.VergiNo;
                txtCepTelefonu.Text = entity.CepTelefonu;
                txtIl.Text = entity.Il;
                txtIlce.Text = entity.Ilce;
                txtSemt.Text = entity.Semt;
                txtAdres.Text = entity.Adres;
                lblAlacak.Text = entityBakiye.Alacak.ToString("C2");
                lblBorc.Text = entityBakiye.Borc.ToString("C2");
                lblBakiye.Text = entityBakiye.Bakiye.ToString("C2");
            }
        }
        private void FiyatSec(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridStokHareket.SetFocusedRowCellValue(colBirimFiyati, Convert.ToDecimal(e.Item.Tag));
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtCariKodu.Text = null;
            txtCariAdi.Text = null;
            txtFaturaUnvani.Text = null;
            txtVergiDairesi.Text = null;
            txtVergiNo.Text = null;
            txtCepTelefonu.Text = null;
            txtIl.Text = null;
            txtIlce.Text = null;
            txtSemt.Text = null;
            txtAdres.Text = null;
            lblAlacak.Text = "Alacak Görüntülenemiyor";
            lblBorc.Text = "Borç Görüntülenemiyor";
            lblBakiye.Text = "Bakiye Görüntülenemiyor";
        }

        private void repoSil_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Veriyi Silmek İstediğinize Eminmisiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                gridStokHareket.DeleteSelectedRows();
                Toplamlar();
            }
        }

        private void repoDepoSecim_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FrmDepoSec form = new FrmDepoSec(gridStokHareket.GetFocusedRowCellValue(colStokKodu).ToString());
            form.ShowDialog();
            if (form.secildi)
            {
                gridStokHareket.SetFocusedRowCellValue(colDepoKodu, form.entity.DepoKodu);
                gridStokHareket.SetFocusedRowCellValue(colDepoAdi, form.entity.DepoAdi);
            }
        }

        private void repoSeriNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string veri = Convert.ToString(gridStokHareket.GetFocusedRowCellValue(colSeriNo));
            FrmSeriNoGir form = new FrmSeriNoGir(veri, false);
            form.ShowDialog();
            gridStokHareket.SetFocusedRowCellValue(colSeriNo, form.veriSeriNo);
        }

        private void repoBirimFiyat_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string fiyatSecilen = gridStokHareket.GetFocusedRowCellValue(colStokKodu).ToString();
            Entities.Tables.Stok fiyatEntity = context.Stoklar.Where(c => c.StokKodu == fiyatSecilen).SingleOrDefault();

            barFiyat1.Tag = _fisEntity.FisTuru == "Alış Faturası" ? fiyatEntity.AlisFiyati1 ?? 0 : fiyatEntity.SatisFiyati1 ?? 0;
            barFiyat2.Tag = _fisEntity.FisTuru == "Alış Faturası" ? fiyatEntity.AlisFiyati2 ?? 0 : fiyatEntity.SatisFiyati2 ?? 0;
            barFiyat3.Tag = _fisEntity.FisTuru == "Alış Faturası" ? fiyatEntity.AlisFiyati3 ?? 0 : fiyatEntity.SatisFiyati3 ?? 0;
            barFiyat1.Caption = string.Format("{0:C2}", barFiyat1.Tag);
            barFiyat2.Caption = string.Format("{0:C2}", barFiyat2.Tag);
            barFiyat3.Caption = string.Format("{0:C2}", barFiyat3.Tag);
            radialFiyat.ShowPopup(MousePosition);
        }

        private void simpleButton14_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton16_Click(object sender, EventArgs e)
        {


        }

        private void btnCariSec_Click(object sender, EventArgs e)
        {
            FrmCariSec form = new FrmCariSec();
            form.ShowDialog();
            if (form.secildi)
            {
                Entities.Tables.Cari entity = form.secilen.FirstOrDefault();
                entityBakiye = cariDal.CariBakiyesi(context, entity.CariKodu);

                txtCariKodu.Text = entity.CariKodu;
                txtCariAdi.Text = entity.CariAdi;
                txtFaturaUnvani.Text = entity.FaturaUnvani;
                txtVergiDairesi.Text = entity.VergiDairesi;
                txtVergiNo.Text = entity.VergiNo;
                txtCepTelefonu.Text = entity.CepTelefonu;
                txtIl.Text = entity.Il;
                txtIlce.Text = entity.Ilce;
                txtSemt.Text = entity.Semt;
                txtAdres.Text = entity.Adres;
                lblAlacak.Text = entityBakiye.Alacak.ToString("C2");
                lblBorc.Text = entityBakiye.Borc.ToString("C2");
                lblBakiye.Text = entityBakiye.Bakiye.ToString("C2");
            }
        }

        private void chUrunBul_Click(object sender, EventArgs e)
        {
            FrmStokSec form = new FrmStokSec();
            form.ShowDialog();
            if (form.secildi)
            {
                stokHareketDal.AddOrUpdate(context, StokSec(form.secilen.First()));
                Toplamlar();
            }
        }

        private void chSatirSil_Click(object sender, EventArgs e)
        {
            if (gridStokHareket.RowCount != 0)
            {
                if (MessageBox.Show("Seçili Olan Veriyi Silmek İstediğinize Eminmisiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    gridStokHareket.DeleteSelectedRows();
                    Toplamlar();
                }
            }
        }

        private void chSatisIptal_Click(object sender, EventArgs e)
        {
            if (gridStokHareket.RowCount != 0)
            {
                if (MessageBox.Show("Mevcut Satışı İptal İstediğinize Eminmisiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _fisEntity = new Fis();
                    _fisEntity.BelgeNo = null;
                    _fisEntity.Aciklama = null;
                    btnTemizle_Click(sender, e);
                    context.StokHareketleri.Local.Clear();
                }
            }
            else
            {
                MessageBox.Show("Mevcutta Bir İşlem Bulunamadı!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChIade_CheckedChanged(object sender, EventArgs e)
        {
            if (ChIade.Checked)
            {
                txtIslem.Text = "İADE";
                txtIslem.BackColor = Color.Red;
            }
            else
            {
                txtIslem.Text = "SATIŞ";
                txtIslem.BackColor = Color.Green;
            }
        }

        private void ParaEkle_Click(object sender, EventArgs e)
        {
            var buton = (sender as SimpleButton);
            txtOdenenTutar.Value += ConverterTool.StringToDecimal(buton.Tag.ToString(), ".");
            Toplamlar();
        }

        private void txtOdenenTutar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            txtOdenenTutar.Value = 0;
        }

        private void gridStokHareket_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            Toplamlar();
        }

        private void txtBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Entities.Tables.Stok entity;
                entity = context.Stoklar.Where(c => c.Barkod == txtBarkod.Text).SingleOrDefault();
                if (entity != null)
                {
                    stokHareketDal.AddOrUpdate(context, StokSec(entity));
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

        private void txtIskontoOrani_Validated(object sender, EventArgs e)
        {
            Toplamlar();
        }
    }
}

using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
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
using SonicHesap.Report.Fatura_Ve_Fiş;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Windows.Forms;

namespace SonicHesap.FrontOffice
{
    public partial class FrmFrontOffice : DevExpress.XtraEditors.XtraForm
    {
        Entities.Tables.Fis _fisEntity = new Entities.Tables.Fis();
        CariDAL cariDal = new CariDAL();
        SonicHesapContext context = new SonicHesapContext();
        CariBakiye entityBakiye = new CariBakiye();
        FisDAL fisDal = new FisDAL();
        KasaHareketDAL kasaHareketDal = new KasaHareketDAL();
        StokHareketDAL stokHareketDal = new StokHareketDAL();
        ExchangeTool doviz = new ExchangeTool();
        private string odemeTuruKodu, odemeTuruAdi;
        decimal eskifiyat = 0;

        int BekleyenSatisId = 0;
        List<BekleyenSatis> _bekleyenSatis = new List<BekleyenSatis>();


        public FrmFrontOffice()
        {
            InitializeComponent();
            gridContStokHareket.DataSource = context.StokHareketleri.Local.ToBindingList();
            gridContKasaHareket.DataSource = context.KasaHareketleri.Local.ToBindingList();
            gridLookUpEdit1.Properties.DataSource = doviz.DovizKuruCek();
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
                if (StokKontrol(entity))
                {
                    stokHareketDal.AddOrUpdate(context, StokSec(entity));
                    Toplamlar();
                }
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
                        BackColor = Color.SteelBlue,
                        ForeColor = Color.White,
                        Appearance = {
                        BackColor = Color.SteelBlue,
                        ForeColor = Color.White
                                     }
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
                    BackColor = Color.SteelBlue,
                    ForeColor = Color.White,
                    Appearance = {
                        BackColor = Color.SteelBlue,
                        ForeColor = Color.White
                                     }
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
                BackColor = Color.SteelBlue,
                ForeColor = Color.White,
                Appearance = {
                        BackColor = Color.SteelBlue,
                        ForeColor = Color.White
                                     },
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
                    BackColor = Color.SteelBlue,
                    ForeColor = Color.White,
                    Appearance = {
                        BackColor = Color.SteelBlue,
                        ForeColor = Color.White
                    },
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
            if (chOdemeBol.Checked)
            {
                if (txtOdenmesiGereken.Value == 0)
                {
                    MessageBox.Show("Ödenmesi Gereken Herhangi Bir Tutar Bulunamadı!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    FrmOdemeEkrani form = new FrmOdemeEkrani(buton.Text, buton.Name, txtOdenmesiGereken.Value);
                    form.ShowDialog();
                    if (form.entity != null)
                    {
                        kasaHareketDal.AddOrUpdate(context, form.entity);
                        OdenenTutarGuncelle();
                    }
                }
            }
            else
            {
                odemeTuruKodu = buton.Name;
                odemeTuruAdi = buton.Text;
                radialYazdir.ShowPopup(MousePosition);
            }
        }

        private void FisiKaydet(ReportsPrintTool.Belge belge)
        {

            int StokHata = context.StokHareketleri.Local.Where(c => c.DepoKodu == null).Count();
            int KasaHata = context.KasaHareketleri.Local.Where(c => c.KasaKodu == null).Count();
            string message = null;
            int hata = 0;

            if (gridStokHareket.RowCount == 0)
            {
                message += ("Satış Ekranında Eklenmiş Bir Ürün Bulunamadı!") + System.Environment.NewLine;
                hata++;
            }

            if (gridKasaHareket.RowCount == 0 && chOdemeBol.Checked)
            {
                message += ("Herhangi Bir Ödeme Bulunamadı!") + System.Environment.NewLine;
                hata++;
            }

            if (string.IsNullOrEmpty(txtFisKodu.Text))
            {
                message += ("Fiş Kodu Alanı Boş Geçilemez!") + System.Environment.NewLine;
                hata++;
            }


            if (StokHata != 0)
            {
                message += ("Satış Ekranındaki Ürünlerin Depo Seçimlerinde Eksiklikler Var!") + System.Environment.NewLine;
                hata++;
            }
            if (KasaHata != 0) // Burada StokHata yerine KasaHata kullanılmalı
            {
                message += ("Ödeme Ekranındaki Ödemelerin Kasa Seçimlerinde Eksiklikler Var!");
                hata++;
            }

            if (txtOdenmesiGereken.Value != 0 && chOdemeBol.Checked)
            {
                message += ("Ödenmesi Gereken Tutar Ödenmemiş Gözüküyor!") + System.Environment.NewLine;
                hata++;
            }

            if (hata != 0) // Burada StokHata yerine KasaHata kullanılmalı
            {
                MessageBox.Show(message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _fisEntity.FisTuru = txtIslem.Text == "İADE" ? "Satış İade Faturası" : "Perakende Satış Faturası";
            foreach (var stokVeri in context.StokHareketleri.Local.ToList())
            {
                stokVeri.Tarih = DateTime.Now;
                stokVeri.FisKodu = txtFisKodu.Text;
                stokVeri.Hareket = txtIslem.Text == "İADE" ? "Stok Giriş" : "Stok Çıkış";
            }
            foreach (var kasaVeri in context.KasaHareketleri.Local.ToList())
            {
                kasaVeri.Tarih = DateTime.Now;
                kasaVeri.FisKodu = txtFisKodu.Text;
                kasaVeri.Hareket = txtIslem.Text == "İADE" ? "Kasa Çıkış" : "Kasa Giriş";
                kasaVeri.CariKodu = txtCariKodu.Text;
                kasaVeri.CariAdi = txtCariAdi.Text;
                kasaVeri.Tutar = txtToplam.Value;
            }
            _fisEntity.ToplamTutar = txtToplam.Value;
            _fisEntity.IskontoOrani = txtIskontoOrani.Value;
            _fisEntity.IskontoTutar = txtIskontoTutar.Value;
            _fisEntity.Tarih = DateTime.Now;
            fisDal.AddOrUpdate(context, _fisEntity);
            string kasaKodu = SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_VarsayilanKasa);
            if (!chOdemeBol.Checked)
            {
                kasaHareketDal.AddOrUpdate(context, new KasaHareket
                {
                    CariKodu = txtCariKodu.Text,
                    CariAdi = txtCariAdi.Text,
                    FisKodu = txtFisKodu.Text,
                    Hareket = txtIslem.Text == "İADE" ? "Kasa Çıkış" : "Kasa Giriş",
                    KasaKodu = kasaKodu,
                    KasaAdi = context.Kasalar.SingleOrDefault(x => x.KasaKodu == kasaKodu).KasaAdi,
                    OdemeTuruKodu = odemeTuruKodu,
                    OdemeTuruAdi = odemeTuruAdi,
                    Tarih = DateTime.Now,
                    Tutar = txtToplam.Value,
                });
                OdenenTutarGuncelle();
            }
            context.SaveChanges();
            chOdemeBol.Checked = false;
            radialYazdir.HidePopup();
            switch (belge)
            {
                case ReportsPrintTool.Belge.Fatura:
                    ReportsPrintTool yazdir = new ReportsPrintTool();
                    rptFatura fatura = new rptFatura(txtFisKodu.Text);
                    yazdir.RaporYazdir(fatura, belge);
                    break;
                case ReportsPrintTool.Belge.BilgiFisi:
                    rptBilgiFisi bilgiFisi = new rptBilgiFisi(txtFisKodu.Text);
                    ReportsPrintTool yazdirBilgiFisi = new ReportsPrintTool();
                    yazdirBilgiFisi.RaporYazdir(bilgiFisi, belge);
                    break;
            }
            FisTemizle();
        }

        private void OdenenTutarGuncelle()
        {
            gridKasaHareket.UpdateSummary();
            txtOdenenTutar.Value = Convert.ToDecimal(colTutar.SummaryItem.SummaryValue);
            txtOdenmesiGereken.Value = txtToplam.Value - txtOdenenTutar.Value;
        }

        private void FisTemizle()
        {
            CariTemizle();
            txtToplam.Text = null;
            txtAraToplam.Text = null;
            txtKDVToplam.Text = null;
            txtIndirimToplam.Text = null;
            txtIskontoOrani.Text = null;
            txtIskontoTutar.Text = null;
            txtOdenenTutar.Text = null;
            txtParaUstu.Text = null;
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
            _fisEntity.FisKodu = null;
            _fisEntity.BelgeNo = null;
            _fisEntity.Aciklama = null;
            context.StokHareketleri.Local.Clear();
            context.KasaHareketleri.Local.Clear();
            OdenenTutarGuncelle();
            Toplamlar();
        }
        private void CariTemizle()
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

        private void btnStokSec_Click(object sender, EventArgs e)
        {
            FrmStokSec form = new FrmStokSec();
            form.ShowDialog();
            if (form.secildi)
            {
                if (StokKontrol(form.secilen.SingleOrDefault()))
                {
                    stokHareketDal.AddOrUpdate(context, StokSec(form.secilen.First()));
                    Toplamlar();
                }
            }
        }

        private bool StokKontrol(Stok entity)
        {
            // Stok Girişlerinden toplam miktar
            var stokGiris = context.StokHareketleri
                                  .Where(c => c.Hareket == "Stok Giriş" && c.Barkod == entity.Barkod)
                                  .Sum(c => c.Miktar) ?? 0;

            // Stok Çıkışlarından toplam miktar
            var stokCikis = context.StokHareketleri
                                  .Where(c => c.Hareket == "Stok Çıkış" && c.Barkod == entity.Barkod)
                                  .Sum(c => c.Miktar) ?? 0;

            // Mevcut Stok Miktarı
            var mevcutStok = stokGiris - stokCikis;

            if (txtIslem.Text == "SATIŞ" && entity.MinStokMiktari > mevcutStok - (txtMiktar.Value))
            {
                MessageBox.Show("Satış Yapmak İstediğiniz Ürünün Stok Durumu Minimum Düzeydedir!\nSatış Yapabilmek İçin Stok Durumunu Kontrol Ediniz!", "Minimum Stok Uyarısı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
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
            txtOdenmesiGereken.Value = txtToplam.Value - txtOdenenTutar.Value;
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
            CariTemizle();
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
                if (StokKontrol(form.secilen.SingleOrDefault()))
                {
                    stokHareketDal.AddOrUpdate(context, StokSec(form.secilen.First()));
                    Toplamlar();
                }
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

        private void txtBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Entities.Tables.Stok entity;
                entity = context.Stoklar.Where(c => c.Barkod == txtBarkod.Text).SingleOrDefault();
                if (entity != null)
                {
                    if (StokKontrol(entity))
                    {
                        stokHareketDal.AddOrUpdate(context, StokSec(entity));
                        Toplamlar();
                    }
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

        private void chOdemeBol_CheckedChanged(object sender, EventArgs e)
        {
            if (chOdemeBol.Checked)
            {
                navigationFrame1.SelectedPage = navOdeme;
            }
            else
            {
                navigationFrame1.SelectedPage = navStokHareket;
            }
        }

        private void BtnFisKaydet_Click(object sender, EventArgs e)
        {
            radialYazdir.ShowPopup(MousePosition);
            MessageBox.Show("Satış Kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FisTemizle();
        }

        private void Fatura_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FisiKaydet(ReportsPrintTool.Belge.Fatura);
            //Fatura
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFisKodu.Text))
            {
                MessageBox.Show("Lütfen geçerli bir fiş kodu girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FisOlustur(txtFisKodu.Text);
        }

        private void FisOlustur(string fisKodu)
        {
            FisiKaydet(ReportsPrintTool.Belge.BilgiFisi);
            //Bilgifisi
            FisTemizle();
        }

        private void gridStokHareket_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (gridStokHareket.FocusedColumn == colMiktar)
            {
                txtMiktar.Value = 0;
                decimal deger = (decimal)e.Value;
                string barkod = gridStokHareket.GetFocusedRowCellValue(colBarkod).ToString();
                if (!StokKontrol(context.Stoklar.SingleOrDefault(c => c.Barkod == barkod)))
                {
                    gridStokHareket.SetFocusedRowCellValue(colMiktar, eskifiyat);
                }
                txtMiktar.Value = 1;
                Toplamlar();
            }
        }

        private void gridStokHareket_ShownEditor(object sender, EventArgs e)
        {
            if (gridStokHareket.FocusedColumn == colMiktar)
            {
                eskifiyat = (decimal)gridStokHareket.GetFocusedRowCellValue(colMiktar);
            }
        }

        private void gridLookUpEdit1View_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridLookUpEdit1View.GetFocusedRow() != null && gridLookUpEdit1View.GetFocusedRowCellValue(colBanknoteSelling) != null)
            {
                try
                {
                    txtDovizTutar.Value = txtToplam.Value / Convert.ToDecimal(gridLookUpEdit1View.GetFocusedRowCellValue(colBanknoteSelling));
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message + " Döviz Kuru Hatası Oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
        private void btnSatisBeklet_Click(object sender, EventArgs e)
        {
            _bekleyenSatis.Add(new BekleyenSatis
            {
                Id = BekleyenSatisId,
                BekleyenFis = _fisEntity,
                StokHareketi = context.StokHareketleri.Local.ToList(),
                KasaHareketi = context.KasaHareketleri.Local.ToList(),
            });

            SimpleButton Bekleyenbuton = new SimpleButton
            {
                Name = BekleyenSatisId.ToString(),
                Text = txtCariKodu.Text + " - " + txtCariAdi.Text + "\n" + _fisEntity.PlasiyerKodu + " - " + _fisEntity.PlasiyerAdi + "\n" + context.StokHareketleri.Local.Count + " " + "Adet Ürün Eklendi." + "\n" + txtToplam.Value.ToString("C2"),
                Height = 150,
                Width = flowBekleyenSatis.Width - 5,
                BackColor = Color.SteelBlue,
                ForeColor = Color.White,
                Appearance = {
                        BackColor = Color.SteelBlue,
                        ForeColor = Color.White
                    }
            };
            Bekleyenbuton.Click += BekleyenSatis_Click;
            flowBekleyenSatis.Controls.Add(Bekleyenbuton);
            FisTemizle();
            btnTemizle_Click(sender, e);
            BekleyenSatisId++;
        }


        private void BekleyenSatis_Click(object sender, EventArgs e)
        {
            var buton = new SimpleButton();
            BekleyenSatisYukle(Convert.ToInt32(buton.Name));
        }

        private void BekleyenSatisYukle(int Id)
        {
            FisTemizle();
            _fisEntity=_bekleyenSatis.SingleOrDefault(c=>c.Id == Id).BekleyenFis;
            foreach(var item in _bekleyenSatis.SingleOrDefault(c=>c.Id==Id).StokHareketi)
            {
              context.StokHareketleri.Local.Add(item);
            }
            foreach (var item in _bekleyenSatis.SingleOrDefault(c => c.Id == Id).KasaHareketi)
            {
                context.KasaHareketleri.Local.Add(item);
            }
        }

        private void repoOHSil_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Veriyi Silmek İstediğinize Eminmisiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                gridKasaHareket.DeleteSelectedRows();
                Toplamlar();
            }
        }
    }
}

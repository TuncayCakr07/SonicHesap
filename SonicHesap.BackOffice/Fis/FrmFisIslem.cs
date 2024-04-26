using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using SonicHesap.BackOffice.Cari;
using SonicHesap.BackOffice.Depo;
using SonicHesap.BackOffice.Kasa;
using SonicHesap.BackOffice.Personel;
using SonicHesap.BackOffice.Stok;
using SonicHesap.Entities.Context;
using SonicHesap.Entities.Data_Access;
using SonicHesap.Entities.Interfaces;
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
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SonicHesap.BackOffice.Fis
{
    public partial class FrmFisIslem : DevExpress.XtraEditors.XtraForm
    {
        Entities.Tables.Fis _fisEntity = new Entities.Tables.Fis();
        FisAyarlari ayarlar = new FisAyarlari();
        CariDAL cariDal = new CariDAL();
        SonicHesapContext contex = new SonicHesapContext();
        CariBakiye entityBakiye = new CariBakiye();
        private Nullable<int> _cariId;
        FisDAL fisDal = new FisDAL();
        KasaHareketDAL kasaHareketDal = new KasaHareketDAL();
        StokHareketDAL stokHareketDal = new StokHareketDAL();
        PersonelHareketDAL personelHareketDal = new PersonelHareketDAL();

        public FrmFisIslem(string fisKodu = null, string fisTuru = null)
        {
            InitializeComponent();
            if (fisKodu != null)
            {
                _fisEntity = contex.fisler.Where(c => c.FisKodu == fisKodu).SingleOrDefault();
                contex.StokHareketleri.Where(c => c.FisKodu == fisKodu).Load();
                contex.KasaHareketleri.Where(c => c.FisKodu == fisKodu).Load();
                contex.PersonelHareketleri.Where(c => c.FisKodu == fisKodu).Load();

                toggleBakiye.IsOn = contex.KasaHareketleri.Count(c => c.FisKodu == fisKodu && c.Hareket == "Kasa Giriş") == 0;

                if (_fisEntity.CariId != null)
                {
                    entityBakiye = cariDal.CariBakiyesi(contex, Convert.ToInt32(_fisEntity.CariId));
                }

                lblAlacak.Text = entityBakiye.Alacak.ToString("C2");
                lblBorc.Text = entityBakiye.Borc.ToString("C2");
                lblBakiye.Text = entityBakiye.Bakiye.ToString("C2");
            }
            else
            {
                _fisEntity.FisTuru = fisTuru;
                _fisEntity.Tarih = DateTime.Now;
            }

            databinding();
            gridContStokHareket.DataSource = contex.StokHareketleri.Local.ToBindingList();
            gridContKasaHareket.DataSource = contex.KasaHareketleri.Local.ToBindingList();
            gridContPersonelHareket.DataSource = contex.PersonelHareketleri.Local.ToBindingList();

            cmbAy.Month = DateTime.Now.Month;
            for (int i = DateTime.Now.Year - 2; i <= DateTime.Now.Year + 36; i++)
            {
                cmbYil.Properties.Items.Add(i);
            }
            cmbYil.Text = DateTime.Now.Year.ToString();
            FisAyar();
            Toplamlar();
            OdenenTutarGuncelle();

            ButonlariYukle();
        }

        private void databinding()
        {
            txtFisTuru.DataBindings.Add("Text", _fisEntity, "FisTuru", false, DataSourceUpdateMode.OnPropertyChanged);
            txtFisKodu.DataBindings.Add("Text", _fisEntity, "FisKodu", false, DataSourceUpdateMode.OnPropertyChanged);
            cmbTarih.DataBindings.Add("EditValue", _fisEntity, "Tarih", false, DataSourceUpdateMode.OnPropertyChanged);
            txtBelgeNo.DataBindings.Add("Text", _fisEntity, "BelgeNo", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAciklama.DataBindings.Add("Text", _fisEntity, "Aciklama", false, DataSourceUpdateMode.OnPropertyChanged);
            lblCariKodu.DataBindings.Add("Text", _fisEntity, "CariKodu", false, DataSourceUpdateMode.OnPropertyChanged);
            lblCariAdi.DataBindings.Add("Text", _fisEntity, "CariAdi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtFaturaUnvani.DataBindings.Add("Text", _fisEntity, "FaturaUnvani", false, DataSourceUpdateMode.OnPropertyChanged);
            txtCepTelefonu.DataBindings.Add("Text", _fisEntity, "CepTelefonu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtIl.DataBindings.Add("Text", _fisEntity, "Il", false, DataSourceUpdateMode.OnPropertyChanged);
            txtIlce.DataBindings.Add("Text", _fisEntity, "Ilce", false, DataSourceUpdateMode.OnPropertyChanged);
            txtSemt.DataBindings.Add("Text", _fisEntity, "Semt", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAdres.DataBindings.Add("Text", _fisEntity, "Adres", false, DataSourceUpdateMode.OnPropertyChanged);
            txtVergiDairesi.DataBindings.Add("Text", _fisEntity, "VergiDairesi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtVergiNo.DataBindings.Add("Text", _fisEntity, "VergiNo", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void ButonlariYukle()
        {
            foreach (var item in contex.OdemeTurleri.ToList())
            {
                var buton = new SimpleButton
                {
                    Name = item.OdemeTuruKodu,
                    Tag = item.Id,
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
                Checked = _fisEntity.PlasiyerId == null
            };
            SecimTemizle.Click += PersonelEkle_Click;
            flowPersonel.Controls.Add(SecimTemizle);

            foreach (var item in contex.Personeller.ToList())
            {
                var buton = new CheckButton
                {
                    Name = item.PersonelKodu,
                    Text = item.PersonelAdi,
                    GroupIndex = 1,
                    Height = 70,
                    Width = 150,
                    Checked = item.Id == _fisEntity.PlasiyerId
                };
                buton.Click += PersonelEkle_Click;
                flowPersonel.Controls.Add(buton);
            }
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            FrmCariSec form = new FrmCariSec();
            form.ShowDialog();
            if (form.secildi)
            {
                Entities.Tables.Cari entity = form.secilen.FirstOrDefault();
                entityBakiye = cariDal.CariBakiyesi(contex, entity.Id);
                _cariId = entity.Id;
                lblCariKodu.Text = entity.CariKodu;
                lblCariAdi.Text = entity.CariAdi;
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

        private void btnKapat_Click(object sender, EventArgs e)
        {

            if (gridStokHareket.RowCount != 0)
            {
                DialogResult result = MessageBox.Show("Satış Ekranında Belgeye Kaydedilmemiş Ürünler Var. Bu İşlemi İptal Edip Belgeyi Kapatmak İstediğinize Eminmisiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (toggleBakiye.IsOn)
            {
                ayarlar.KasaHareketi = "Kasa Çıkış"; // Doğru kasa hareketini atadığınızdan emin olun
            }
            else
            {
                ayarlar.KasaHareketi = "Kasa Giriş"; // Doğru kasa hareketini atadığınızdan emin olun
            }
            int StokHata = contex.StokHareketleri.Local.Where(c => c.DepoKodu == null).Count();
            string message = null;
            int hata = 0;

            if (gridStokHareket.RowCount == 0 && ayarlar.SatisEkrani == true)
            {
                message += ("Satış Ekranında Eklenmiş Bir Ürün Bulunamadı!") + System.Environment.NewLine;
                hata++;
            }

            if (_fisEntity.CariId == null && ayarlar.SatisEkrani == false && txtFisTuru.Text!="Hakediş Fişi")
            {
                message += (txtFisTuru.Text + " " + "Türünde Cari Seçimi Zorunludur!") + System.Environment.NewLine;
                hata++;
            }

            if (gridKasaHareket.RowCount == 0 && ayarlar.SatisEkrani == false && txtFisTuru.Text != "Hakediş Fişi")
            {
                message += ("Herhangi Bir Ödeme Bulunamadı!") + System.Environment.NewLine;
                hata++;
            }

            if (string.IsNullOrEmpty(txtFisKodu.Text))
            {
                message += ("Fiş Kodu Alanı Boş Geçilemez!") + System.Environment.NewLine;
                hata++;
            }

            if (txtOdenmesiGereken.Value != 0 && ayarlar.OdemeEkrani == true && String.IsNullOrEmpty(lblCariKodu.Text) && txtFisTuru.Text != "Hakediş Fişi")
            {
                message += ("Ödenmesi Gereken Tutar Ödenmemiş Gözüküyor. Ödenmeyen Kısmı Açık Hesaba Aktarabilmek İçin Cari Seçmek Zorunludur!") + System.Environment.NewLine;
                hata++;
            }

            if (StokHata != 0)
            {
                message += ("Satış Ekranındaki Ürünlerin Depo Seçimlerinde Eksiklikler Var!") + System.Environment.NewLine;
                hata++;
            }

            if (hata != 0) // Burada StokHata yerine KasaHata kullanılmalı
            {
                MessageBox.Show(message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtOdenmesiGereken.Value != 0 && ayarlar.OdemeEkrani==true)
            {
                if (MessageBox.Show($"Ödemenin {txtOdenmesiGereken.Value.ToString("C2")} Tutarındaki Kısmı Açık Hesap Bakiyesi Olarak Kaydedilecektir.Devam Etmek İstiyor Musunuz?", "Uyarı!", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    MessageBox.Show("İstek Kullanıcı Tarafından İptal Edildi!");
                    return;
                }
            }

            foreach (var stokVeri in contex.StokHareketleri.Local.ToList())
            {
                stokVeri.Tarih = stokVeri.Tarih == null ? Convert.ToDateTime(cmbTarih.DateTime) : Convert.ToDateTime(stokVeri.Tarih);
                stokVeri.FisKodu = txtFisKodu.Text;
                stokVeri.Hareket = ayarlar.StokHareketi;
            }

            foreach (var item in contex.PersonelHareketleri.Local.ToList())
            {
                item.FisKodu = txtFisKodu.Text;
            }

            if (ayarlar.OdemeEkrani)
            {
                foreach (var kasaVeri in contex.KasaHareketleri.Local.ToList())
                {
                    kasaVeri.Tarih = kasaVeri.Tarih == null ? Convert.ToDateTime(cmbTarih.DateTime) : Convert.ToDateTime(kasaVeri.Tarih);
                    kasaVeri.FisKodu = txtFisKodu.Text;
                    kasaVeri.Hareket = ayarlar.KasaHareketi;
                    if (txtFisTuru.Text!="Hakediş Fişi")
                    {
                        kasaVeri.CariId =_cariId;
                    }
                    kasaVeri.Tutar = txtToplam.Value;
                }
            }
            _fisEntity.ToplamTutar = txtToplam.Value;
            _fisEntity.IskontoOrani = txtIskontoOrani.Value;
            _fisEntity.IskontoTutar = txtIskontoTutar.Value;
            fisDal.AddOrUpdate(contex, _fisEntity);
            contex.SaveChanges();
            Toplamlar();
            MessageBox.Show("Belge Kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
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

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            _cariId = null;
            lblCariKodu.Text = null;
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

        private void FisAyar()
        {
            switch (_fisEntity.FisTuru)
            {
                case "Alış Faturası":
                    ayarlar.StokHareketi = "Stok Giriş";
                    ayarlar.KasaHareketi = "Kasa Çıkış";
                    ayarlar.OdemeEkrani = true;
                    ayarlar.SatisEkrani = true;
                    lblBaslik.ImageOptions.ImageIndex = 0;
                    navPersonelIslem.Dispose();
                    break;
                case "Perakende Satış Faturası":
                    ayarlar.StokHareketi = "Stok Çıkış";
                    ayarlar.KasaHareketi = "Kasa Giriş";
                    ayarlar.OdemeEkrani = true;
                    ayarlar.SatisEkrani = true;
                    lblBaslik.ImageOptions.ImageIndex = 1;
                    navPersonelIslem.Dispose();
                    break;
                case "Toptan Satış Faturası":
                    ayarlar.StokHareketi = "Stok Çıkış";
                    ayarlar.KasaHareketi = "Kasa Giriş";
                    ayarlar.OdemeEkrani = true;
                    ayarlar.SatisEkrani = true;
                    lblBaslik.ImageOptions.ImageIndex = 2;
                    navPersonelIslem.Dispose();
                    break;
                case "Alış İade Faturası":
                    ayarlar.StokHareketi = "Stok Çıkış";
                    ayarlar.KasaHareketi = "Kasa Giriş";
                    ayarlar.OdemeEkrani = true;
                    ayarlar.SatisEkrani = true;
                    lblBaslik.ImageOptions.ImageIndex = 3;
                    navPersonelIslem.Dispose();
                    break;
                case "Satış İade Faturası":
                    ayarlar.StokHareketi = "Stok Giriş";
                    ayarlar.KasaHareketi = "Kasa Çıkış";
                    ayarlar.OdemeEkrani = true;
                    ayarlar.SatisEkrani = true;
                    lblBaslik.ImageOptions.ImageIndex = 4;
                    navPersonelIslem.Dispose();
                    break;
                case "Sayım Fazlası Fişi":
                    ayarlar.StokHareketi = "Stok Giriş";
                    ayarlar.OdemeEkrani = false;
                    ayarlar.SatisEkrani = true;
                    lblBaslik.ImageOptions.ImageIndex = 5;
                    navOdemeEkrani.Dispose();
                    navCariBilgi.Dispose();
                    navPersonelIslem.Dispose();
                    panelOdeme.Visible = false;
                    break;
                case "Sayım Eksiği Fişi":
                    ayarlar.StokHareketi = "Stok Çıkış";
                    ayarlar.OdemeEkrani = false;
                    ayarlar.SatisEkrani = true;
                    lblBaslik.ImageOptions.ImageIndex = 6;
                    panelOdeme.Visible = false;
                    navOdemeEkrani.Dispose();
                    navCariBilgi.Dispose();
                    navPersonelIslem.Dispose();
                    break;
                case "Stok Devir Fişi":
                    ayarlar.StokHareketi = "Stok Giriş";
                    ayarlar.OdemeEkrani = false;
                    ayarlar.SatisEkrani = true;
                    lblBaslik.ImageOptions.ImageIndex = 7;
                    panelOdeme.Visible = false;
                    navOdemeEkrani.Dispose();
                    navCariBilgi.Dispose();
                    navPersonelIslem.Dispose();
                    break;
                case "Tahsilat Fişi":
                    ayarlar.KasaHareketi = "Kasa Giriş";
                    ayarlar.OdemeEkrani = true;
                    ayarlar.SatisEkrani = false;
                    navSatisEkrani.Dispose();
                    navPersonelIslem.Dispose();
                    panelOdeme.Visible = false;
                    panelIskontoIndirim.Visible = false;
                    panelKdv.Visible = false;
                    groupToplamlar.Height = 164;
                    panelToplam.Top = 28;
                    navigationPane2.SelectedPage = navOdemeEkrani;
                    break;
                case "Ödeme Fişi":
                    ayarlar.KasaHareketi = "Kasa Çıkış";
                    ayarlar.OdemeEkrani = true;
                    ayarlar.SatisEkrani = false;
                    panelOdeme.Visible = false;
                    panelIskontoIndirim.Visible = false;
                    panelKdv.Visible = false;
                    groupToplamlar.Height = 164;
                    panelToplam.Top = 28;
                    navSatisEkrani.Dispose();
                    navPersonelIslem.Dispose();
                    navigationPane2.SelectedPage = navOdemeEkrani;
                    break;

                case "Cari Devir Fişi":
                    ayarlar.OdemeEkrani = true; // ya da false, ihtiyaca göre
                    ayarlar.SatisEkrani = false; // ya da true, ihtiyaca göre
                    panelOdeme.Visible = false;
                    panelIskontoIndirim.Visible = false;
                    panelKdv.Visible = false;
                    panelCariDevir.Visible = true;
                    groupToplamlar.Height = 164;
                    panelToplam.Top = 28;
                    navSatisEkrani.Dispose();
                    navPersonelIslem.Dispose();
                    txtFisKodu.Width = 386;
                    navigationPane2.SelectedPage = navOdemeEkrani; // ya da navCariBilgi, ihtiyaca göre// Kasa hareketinin açıklamasını belirt // Kasa hareketini kaydet
                    break;

                case "Hakediş Fişi":
                    ayarlar.KasaHareketi = "Kasa Çıkış";
                    ayarlar.OdemeEkrani = true;
                    ayarlar.SatisEkrani = false;
                    panelIskontoIndirim.Visible = false;
                    panelKdv.Visible = false;
                    navSatisEkrani.Dispose();
                    navCariBilgi.Dispose();
                    navPlasiyerBilgi.Dispose();
                    navigationPane2.SelectedPage = navPersonelIslem; // ya da navCariBilgi, ihtiyaca göre// Kasa hareketinin açıklamasını belirt // Kasa hareketini kaydet
                    break;

            }
        }

        private void FiyatSec(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridStokHareket.SetFocusedRowCellValue(colBirimFiyati, Convert.ToDecimal(e.Item.Tag));
        }

        private void FrmFisIslem_Load(object sender, EventArgs e)
        {

        }

        private void gridStokHareket_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            Toplamlar();
        }


        private void OdemeEkle_Click(object sender, EventArgs e)
        {
            var buton = (sender as SimpleButton);
            if (ayarlar.SatisEkrani == false && txtFisTuru.Text!="Hakediş Fişi")
            {
                FrmOdemeEkrani form = new FrmOdemeEkrani(Convert.ToInt32(buton.Tag));
                form.ShowDialog();
                if (form.entity != null)
                {
                    // Ödeme türü adını da ekleyin
                    form.entity.OdemeTuru.OdemeTuruAdi = buton.Text;
                    kasaHareketDal.AddOrUpdate(contex, form.entity);
                    OdenenTutarGuncelle();
                }
            }
            else
            {
                string odemeTuruKodu = buton.Name;
                string odemeTuruAdi = buton.Text;

                if (txtOdenmesiGereken.Value <= 0)
                {
                    MessageBox.Show("Ödeme Yapılacak Tutar Bulunamadı!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (txtFisTuru.Text != "Hakediş Fişi")
                    {
                        KasaHareket entitykasaHareket = new KasaHareket
                        {
                            OdemeTuruId = Convert.ToInt32(buton.Tag),
                            Tarih=DateTime.Now,
                            Tutar = txtOdenmesiGereken.Value
                        };
                        kasaHareketDal.AddOrUpdate(contex, entitykasaHareket);
                        OdenenTutarGuncelle();
                    }
                    else
                    {
                        for (int i = 0; i < gridPersonelHareket.RowCount; i++)
                        {
                            KasaHareket entitykasaHareket = new KasaHareket
                            {
                                CariId = _cariId,
                                OdemeTuruId = Convert.ToInt32(buton.Tag),
                                Tutar = Convert.ToDecimal(gridPersonelHareket.GetRowCellValue(i,colOdenecekTutar)),
                                Aciklama=$"{gridPersonelHareket.GetRowCellValue(i, colPersonelKodu).ToString()} - {gridPersonelHareket.GetRowCellValue(i, colPersonelAdi).ToString()} - Aylık Maaş : {Convert.ToDecimal(gridPersonelHareket.GetRowCellValue(i, colAylikMaasi)).ToString("C2")} || Prim Tutarı : {Convert.ToDecimal(gridPersonelHareket.GetRowCellValue(i, colPrimTutari)).ToString("C2")}"
                            };
                            kasaHareketDal.AddOrUpdate(contex, entitykasaHareket);
                        }
                        OdenenTutarGuncelle();
                    }
                }
            }
        }

        private void OdenenTutarGuncelle()
        {
            gridKasaHareket.UpdateSummary();
            if (ayarlar.SatisEkrani || _fisEntity.FisTuru=="Hakediş Fişi")
            {
                txtOdenenTutar.Value = Convert.ToDecimal(colTutar.SummaryItem.SummaryValue);
                txtOdenmesiGereken.Value = txtToplam.Value - txtOdenenTutar.Value;
            }
            else
            {
                txtToplam.Value = Convert.ToDecimal(colTutar.SummaryItem.SummaryValue);
            }
        }

        private void PersonelEkle_Click(object sender, EventArgs e)
        {

            var buton = sender as CheckButton;
            if (buton.Name == "Temizle")
            {
                _fisEntity.PlasiyerId = null;
            }
            else
            {
                _fisEntity.Personel.PersonelKodu = buton.Name;
                _fisEntity.Personel.PersonelAdi = buton.Text;
            }

        }

        private void repoBirimFiyat_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string fiyatSecilen = gridStokHareket.GetFocusedRowCellValue(colStokKodu).ToString();
            Entities.Tables.Stok fiyatEntity = contex.Stoklar.Where(c => c.StokKodu == fiyatSecilen).SingleOrDefault();

            barFiyat1.Tag = txtFisTuru.Text == "Alış Faturası" ? fiyatEntity.AlisFiyati1 ?? 0 : fiyatEntity.SatisFiyati1 ?? 0;
            barFiyat2.Tag = txtFisTuru.Text == "Alış Faturası" ? fiyatEntity.AlisFiyati2 ?? 0 : fiyatEntity.SatisFiyati2 ?? 0;
            barFiyat3.Tag = txtFisTuru.Text == "Alış Faturası" ? fiyatEntity.AlisFiyati3 ?? 0 : fiyatEntity.SatisFiyati3 ?? 0;
            barFiyat1.Caption = string.Format("{0:C2}", barFiyat1.Tag);
            barFiyat2.Caption = string.Format("{0:C2}", barFiyat2.Tag);
            barFiyat3.Caption = string.Format("{0:C2}", barFiyat3.Tag);
            radialFiyat.ShowPopup(MousePosition);
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

        private void repoKasa_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FrmKasaSecim form = new FrmKasaSecim();
            form.ShowDialog();
            if (form.secildi)
            {
                gridKasaHareket.SetFocusedRowCellValue(colKasaKodu, form.entity.KasaKodu);
                gridKasaHareket.SetFocusedRowCellValue(colKasaAdi, form.entity.KasaAdi);
            }
        }

        private void repoOHSil_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Veriyi Silmek İstediğinize Eminmisiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                gridKasaHareket.DeleteSelectedRows();
                OdenenTutarGuncelle();
            }

        }

        private void repoSeriNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string veri = Convert.ToString(gridStokHareket.GetFocusedRowCellValue(colSeriNo));
            FrmSeriNoGir form = new FrmSeriNoGir(veri);
            form.ShowDialog();
            gridStokHareket.SetFocusedRowCellValue(colSeriNo, form.veriSeriNo);
        }

        private void repoSil_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Veriyi Silmek İstediğinize Eminmisiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                gridStokHareket.DeleteSelectedRows();
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
            stokHareket.IndirimOrani = indirimDal.StokIndirimi(contex, entity.StokKodu);
            stokHareket.DepoKodu = SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_VarsayilanDepo);
            stokHareket.DepoAdi = contex.Depolar.SingleOrDefault(x => x.Id == Convert.ToInt32(stokHareket.DepoKodu)).DepoAdi;
            stokHareket.BarkodTuru = entity.BarkodTuru;
            stokHareket.BirimFiyati = txtFisTuru.Text == "Alış Faturası" ? entity.AlisFiyati1 : entity.SatisFiyati1;
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
            if (_fisEntity.FisTuru == "Hakediş Fişi")
            {
                txtToplam.Value = Convert.ToDecimal(colOdenecekTutar.SummaryItem.SummaryValue);
            }
            else
            {
                txtToplam.Value = Convert.ToDecimal(colToplamTutar.SummaryItem.SummaryValue) - txtIskontoTutar.Value;
            }
            txtKdvToplam.Value = Convert.ToDecimal(colKdvToplam.SummaryItem.SummaryValue);
            txtIndirimToplam.Value = Convert.ToDecimal(colIndirimtutari.SummaryItem.SummaryValue);
            txtOdenmesiGereken.Value = txtToplam.Value - txtOdenenTutar.Value;
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

        private void txtIskontoOrani_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtIskontoOrani_Validated(object sender, EventArgs e)
        {
            Toplamlar();
        }

        private void txtToplam_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnPersonelBul_Click(object sender, EventArgs e)
        {
            DateTime time = new DateTime(Convert.ToInt32(cmbYil.Text), cmbAy.Month, 1);
            FrmPersonelSec form = new FrmPersonelSec(time);
            form.ShowDialog();
            if (form.secildi)
            {
                foreach (var item in form.secilen.ToList())
                {
                    if (contex.PersonelHareketleri.Local.Count(c => c.Donemi==time && c.PersonelKodu == item.PersonelKodu) == 0)
                    {
                        personelHareketDal.AddOrUpdate(contex, item);
                    }
                    else
                    {
                        MessageBox.Show("Personel Daha Önce Eklenmiş!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                Toplamlar();
            }
        }
    }
}
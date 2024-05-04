using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using DevExpress.XtraTab;
using SonicHesap.Admin;
using SonicHesap.BackOffice.Cari;
using SonicHesap.BackOffice.Depo;
using SonicHesap.BackOffice.Fis;
using SonicHesap.BackOffice.Kasa;
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
using static SonicHesap.Entities.Tools.ReportsPrintTool;

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
        private int odemeTuruId;
        decimal eskifiyat = 0;
        private bool tekparca = false;

        int BekleyenSatisId = 0;
        private int cagirilanSatisId = -1;
        List<BekleyenSatis> _bekleyenSatis = new List<BekleyenSatis>();

        private Nullable<int> _cariId;

        public FrmFrontOffice()
        {
            InitializeComponent();

            FrmKullaniciGiris girisform = new FrmKullaniciGiris();
            girisform.ShowDialog();

            context.Stoklar.Load();
            context.Depolar.Load();

            gridContStokHareket.DataSource = context.StokHareketleri.Local.ToBindingList();
            gridContKasaHareket.DataSource = context.KasaHareketleri.Local.ToBindingList();
            gridLookUpEdit1.Properties.DataSource = doviz.DovizKuruCek();

            txtFisKodu.Text = FisNumarasiGetir();
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

            var AcikHesapButon = new SimpleButton
            {
                Name = "AcikHesap",
                Text = "Açık Hesap",
                Height = 55,
                Width = 110,
                BackColor = Color.SteelBlue,
                ForeColor = Color.White,
                Appearance = {
                        BackColor = Color.SteelBlue,
                        ForeColor = Color.White
                                     }
            };
            AcikHesapButon.Click += AcikHesap_Click;
            flowOdemeTurleri.Controls.Add(AcikHesapButon);

            foreach (var item in context.OdemeTurleri.ToList())
            {
                var buton = new SimpleButton
                {
                    Name = item.OdemeTuruKodu,
                    Tag = item.Id,
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
                    Tag = item.Id,
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

        private void AcikHesap_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCariKodu.Text))
            {
                DialogResult result = MessageBox.Show("Açık Hesap Ödeme Tipinde Cari Seçimi Zorunludur! Lütfen Cari Seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    return; // Kullanıcı vazgeçti, işlemi iptal et
                }
            }
            odemeTuruId = -1;
            radialYazdir.ShowPopup(MousePosition);
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
                _fisEntity.PlasiyerId = Convert.ToInt32(buton.Tag);
            }

        }
        private void OdemeEkle_Click(object sender, EventArgs e)
        {
            var buton = (sender as SimpleButton);
            string kasaKodu = SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_VarsayilanKasa);
            string kasaAdi = SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_VarsayilanKasaAdi);
            if (chOdemeBol.Checked && tekparca == false)
            {
                if (txtOdenmesiGereken.Value == 0)
                {
                    MessageBox.Show("Ödenmesi Gereken Herhangi Bir Tutar Bulunamadı!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    FrmOdemeEkrani form = new FrmOdemeEkrani(Convert.ToInt32(buton.Tag), txtOdenmesiGereken.Value);
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
                odemeTuruId = Convert.ToInt32(buton.Tag);
                tekparca = true;
                radialYazdir.ShowPopup(MousePosition);
            }
        }

        private void FisiKaydet(ReportsPrintTool.Belge belge)
        {
            Toplamlar();
            OdenenTutarGuncelle();
            string message = null;
            int hata = 0;

            if (gridStokHareket.RowCount == 0)
            {
                message += ("Satış Ekranında Eklenmiş Bir Ürün Bulunamadı!") + System.Environment.NewLine;
                hata++;
            }

            if (gridKasaHareket.RowCount == 0 && chOdemeBol.Checked && String.IsNullOrEmpty(txtCariKodu.Text))
            {
                message += ("Herhangi Bir Ödeme Bulunamadı!") + System.Environment.NewLine;
                hata++;
            }

            if (string.IsNullOrEmpty(txtFisKodu.Text))
            {
                message += ("Fiş Kodu Alanı Boş Geçilemez!") + System.Environment.NewLine;
                hata++;
            }

            if (txtOdenmesiGereken.Value != 0 && String.IsNullOrEmpty(txtCariKodu.Text) && tekparca == false)
            {
                message += ("Ödenmesi Gereken Tutar Ödenmemiş Gözüküyor! \n Ödenmeyen Kısmı Açık Hesaba Aktarabilmeniz İçin Cari Seçmeniz Gerekmektedir!") + System.Environment.NewLine;
                hata++;
            }

            if (!String.IsNullOrEmpty(txtCariKodu.Text) && (entityBakiye.Bakiye - txtOdenmesiGereken.Value) < 0 && ((entityBakiye.Bakiye - txtOdenmesiGereken.Value) * -1) > entityBakiye.RiskLimiti)
            {
                message += "Cari Risk Limiti Aşılıyor!\n Satış Yapılamaz!" + System.Environment.NewLine;
                hata++;
            }

            if (hata != 0)
            {
                MessageBox.Show(message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (chOdemeBol.Checked && txtOdenmesiGereken.Value != 0)
            {
                if (MessageBox.Show($"Ödemenin {txtOdenmesiGereken.Value.ToString("C2")} Tutarındaki Kısmı Açık Hesap Bakiyesi Olarak Kaydedilecektir.Devam Etmek İstiyor Musunuz?", "Uyarı!", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    MessageBox.Show("İstek Kullanıcı Tarafından İptal Edildi!");
                    return;
                }
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
                kasaVeri.CariId = _cariId;
                kasaVeri.Tutar = txtToplam.Value;
            }
            _fisEntity.FisKodu = txtFisKodu.Text;
            _fisEntity.BelgeNo = txtBelgeNo.Text;
            _fisEntity.Aciklama = txtAciklama.Text;
            _fisEntity.FaturaUnvani = txtFaturaUnvani.Text;
            _fisEntity.CepTelefonu = txtCepTelefonu.Text;
            _fisEntity.Il=txtIl.Text;
            _fisEntity.Ilce=txtIlce.Text;
            _fisEntity.Semt=txtSemt.Text;
            _fisEntity.Adres=txtAdres.Text;
            _fisEntity.VergiDairesi = txtVergiDairesi.Text;
            _fisEntity.VergiNo = txtVergiNo.Text;
            _fisEntity.ToplamTutar = txtToplam.Value;
            _fisEntity.IskontoOrani = txtIskontoOrani.Value;
            _fisEntity.IskontoTutar = txtIskontoTutar.Value;
            _fisEntity.Tarih = DateTime.Now;

            fisDal.AddOrUpdate(context, _fisEntity);

            int kasaId = Convert.ToInt32(SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_VarsayilanKasa));
            if (!chOdemeBol.Checked && odemeTuruId != -1)
            {
                kasaHareketDal.AddOrUpdate(context, new KasaHareket
                {
                    CariId = _cariId,
                    FisKodu = txtFisKodu.Text,
                    Hareket = txtIslem.Text == "İADE" ? "Kasa Çıkış" : "Kasa Giriş",
                    KasaId = kasaId,
                    OdemeTuruId = odemeTuruId,
                    Tarih = DateTime.Now,
                    Tutar = txtToplam.Value,
                }); ;
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

            if (cagirilanSatisId != -1)
            {
                var secilen = _bekleyenSatis.SingleOrDefault(c => c.Id == cagirilanSatisId);
                _bekleyenSatis.Remove(secilen);
                flowBekleyenSatis.Controls.Find(Convert.ToString(cagirilanSatisId), false).SingleOrDefault().Dispose();
                cagirilanSatisId = -1;
            }

            FisTemizle();
            int fisno = (int.Parse(SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_FisKodu))) + 1;
            SettingsTool.AyarDegistir(SettingsTool.Ayarlar.SatisAyarlari_FisKodu, fisno.ToString());
            SettingsTool.Save();


            //***** 
            tekparca = false;
        }

        private void OdenenTutarGuncelle()
        {
            gridKasaHareket.UpdateSummary();
            txtOdenenTutar.Value = Convert.ToDecimal(colTutar.SummaryItem.SummaryValue);
            txtOdenmesiGereken.Value = txtToplam.Value - txtOdenenTutar.Value;
        }

        private void FisTemizle()
        {

            txtFisKodu.Text = "";
            txtToplam.Text = null;
            txtAraToplam.Text = null;
            txtKDVToplam.Text = null;
            txtIndirimToplam.Text = null;
            txtIskontoOrani.Value = 0;
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
            var cikarilacakKayit = context.ChangeTracker.Entries().Where(c => c.Entity is KasaHareket || c.Entity is StokHareket || c.Entity is Fis).ToList();
            foreach (var kayit in cikarilacakKayit)
            {
                context.Entry(kayit.Entity).State = EntityState.Detached;
            }
            _fisEntity = new Fis();
            CariTemizle();
            OdenenTutarGuncelle();
            Toplamlar();
        }
        private void CariTemizle()
        {
            txtCariKodu.Text = null;
            txtCariAdi.Text = null;
            _fisEntity.CariId=null;
            txtFaturaUnvani.Text = null;
            txtVergiDairesi.Text = null;
            txtVergiNo.Text = null;
            txtCepTelefonu.Text = null;
            txtIl.Text = null;
            txtIlce.Text = null;
            txtSemt.Text = null;
            txtAdres.Text = null;
            lblAlacak.Text = "Alacak Görüntülenemiyor";
            lblRiskLimiti.Text = "Risk Limiti Görüntülenemiyor";
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
            var stokGiris = context.StokHareketleri.Where(c => c.Hareket == "Stok Giriş" && c.StokId == entity.Id).Sum(c => c.Miktar) ?? 0;
            // Stok Çıkışlarından toplam miktar
            var stokCikis = context.StokHareketleri.Where(c => c.Hareket == "Stok Çıkış" && c.StokId == entity.Id).Sum(c => c.Miktar) ?? 0;
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
            stokHareket.StokId = entity.Id;
            stokHareket.IndirimOrani = indirimDal.StokIndirimi(context, entity.StokKodu);
            stokHareket.DepoId = Convert.ToInt32(SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_VarsayilanDepo));
            stokHareket.BirimFiyati = _fisEntity.FisTuru == "Alış Faturası" ? entity.AlisFiyati1 : entity.SatisFiyati1;
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
            if (txtFisKodu.Text == "")
            {
                txtFisKodu.Text = FisNumarasiGetir();
            }
            FrmCariSec form = new FrmCariSec();
            form.ShowDialog();
            if (form.secildi)
            {
                Entities.Tables.Cari entity = form.secilen.FirstOrDefault();
                entityBakiye = cariDal.CariBakiyesi(context, entity.Id);
                _cariId = entity.Id;
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


        private void btnCariSec_Click(object sender, EventArgs e)
        {
            FrmCariSec form = new FrmCariSec();
            form.ShowDialog();
            if (form.secildi)
            {
                Entities.Tables.Cari entity = form.secilen.FirstOrDefault();
                entityBakiye = cariDal.CariBakiyesi(context, entity.Id);
                _cariId = entity.Id;
                _fisEntity.CariId = entity.Id;
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
                lblRiskLimiti.Text = entityBakiye.RiskLimiti.ToString("C2");
                lblAlacak.Text = entityBakiye.Alacak.ToString("C2");
                lblBorc.Text = entityBakiye.Borc.ToString("C2");
                lblBakiye.Text = entityBakiye.Bakiye.ToString("C2");
            }
            if (txtFisKodu.Text == "")
            {
                txtFisKodu.Text = FisNumarasiGetir();
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
                flowOdemeTurleri.Controls.Find("AcikHesap", false).SingleOrDefault().Enabled = false;
            }
            else
            {
                navigationFrame1.SelectedPage = navStokHareket;
                flowOdemeTurleri.Controls.Find("AcikHesap", false).SingleOrDefault().Enabled = true;
            }
        }

        private void BtnFisKaydet_Click(object sender, EventArgs e)
        {
            if (txtOdenmesiGereken.Value > 0 && chOdemeBol.Checked && String.IsNullOrEmpty(txtCariKodu.Text) && tekparca == false)
            {
                DialogResult result = MessageBox.Show("Ödenmesi gereken tutar var ve belgesiz ödeme seçili veya cari seçilmemiş. Devam etmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {

                    return; // Kullanıcı vazgeçti, işlemi iptal et
                }
            }

            if (String.IsNullOrEmpty(txtCariKodu.Text))
            {
                MessageBox.Show("Lütfen bir cari hesap seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var _entityBakiye = entityBakiye.Bakiye;
            decimal kalanBakiye = entityBakiye.Bakiye - txtOdenmesiGereken.Value;

            if (kalanBakiye < 0 && Math.Abs(kalanBakiye) > entityBakiye.RiskLimiti)
            {
                MessageBox.Show("Cari Risk Limiti Aşılıyor!\nSatış Yapılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            radialYazdir.ShowPopup(MousePosition);
            FisiKaydet(ReportsPrintTool.Belge.Diger);
            SettingsTool.Save();
            FisTemizle();
        }


        private void Fatura_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FisiKaydet(ReportsPrintTool.Belge.Fatura);
            MessageBox.Show("Satış Kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            MessageBox.Show("Satış Kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Bilgifisi 
            FisTemizle();
            txtFisKodu.Text = FisNumarasiGetir(); 
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
            }
            Toplamlar();
            OdenenTutarGuncelle();
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
            SatisBeklet();
        }

        private void SatisBeklet()
        {
            int BekleyenId;
            BekleyenSatis satis;
            if (cagirilanSatisId != -1)
            {
                BekleyenId = cagirilanSatisId;
                satis = _bekleyenSatis.SingleOrDefault(c => c.Id == BekleyenId);
                var buton = (SimpleButton)flowBekleyenSatis.Controls.Find(Convert.ToString(BekleyenId), false).SingleOrDefault();
                Text = txtCariKodu.Text + " - " + txtCariAdi.Text + "\n" + _fisEntity.Personel.PersonelKodu + " - " + _fisEntity.Personel.PersonelAdi + "\n" + context.StokHareketleri.Local.Count + " " + "Adet Ürün Eklendi." + "\n" + txtToplam.Value.ToString("C2");
            }
            else
            {
                BekleyenId = BekleyenSatisId;
                satis = new BekleyenSatis();
                satis.BekleyenFis = new Fis();
                satis.Id = BekleyenId;
                SimpleButton Bekleyenbuton = new SimpleButton
                {
                    Name = BekleyenSatisId.ToString(),
                    Text = txtCariKodu.Text + " - " + txtCariAdi.Text + "\n" + _fisEntity.Personel.PersonelKodu + " - " + _fisEntity.Personel.PersonelAdi + "\n" + context.StokHareketleri.Local.Count + " " + "Adet Ürün Eklendi." + "\n" + txtToplam.Value.ToString("C2"),
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
                BekleyenSatisId++;
            }
            satis.BekleyenFis.CariId = _fisEntity.CariId;
            satis.BekleyenFis.Aciklama = _fisEntity.Aciklama;
            satis.BekleyenFis.Adres = _fisEntity.Adres;
            satis.BekleyenFis.BelgeNo = _fisEntity.BelgeNo;
            satis.BekleyenFis.CepTelefonu = _fisEntity.CepTelefonu;
            satis.BekleyenFis.FaturaUnvani = _fisEntity.FaturaUnvani;
            satis.BekleyenFis.FisKodu = _fisEntity.FisKodu;
            satis.BekleyenFis.FisTuru = _fisEntity.FisTuru;
            satis.BekleyenFis.Il = _fisEntity.Il;
            satis.BekleyenFis.Ilce = _fisEntity.Ilce;
            satis.BekleyenFis.Semt = _fisEntity.Semt;
            satis.BekleyenFis.PlasiyerId = _fisEntity.PlasiyerId;
            satis.BekleyenFis.VergiDairesi = _fisEntity.VergiDairesi;
            satis.BekleyenFis.VergiNo = _fisEntity.VergiNo;
            satis.BekleyenFis.IskontoOrani = txtIskontoOrani.Value;
            satis.BekleyenFis.IskontoTutar = txtIskontoTutar.Value;
            satis.StokHareketi = context.StokHareketleri.Local.ToList();
            satis.KasaHareketi = context.KasaHareketleri.Local.ToList();
            if (cagirilanSatisId == -1)
            {
                _bekleyenSatis.Add(satis);
            }
            cagirilanSatisId = -1;
            FisTemizle();
            txtFisKodu.Text = FisNumarasiGetir();
        }


        private void BekleyenSatis_Click(object sender, EventArgs e)
        {
            var buton = sender as SimpleButton;
            BekleyenSatisYukle(Convert.ToInt32(buton.Name));
        }

        private void BekleyenSatisYukle(int Id)
        {
            if (cagirilanSatisId == -1 && gridStokHareket.RowCount != 0)
            {
                if (MessageBox.Show("Bekleyen Satış Üzerinde İşlem Yapmadan Önce Mevcut Satışı Beklemeye Almak İster Misiniz?", "Satış Bekletme Uyarısı!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SatisBeklet();
                }
                else
                {
                    return;
                }
            }
            FisTemizle();

            var satisBilgisi = _bekleyenSatis.SingleOrDefault(c => c.Id == Id);
            txtFisKodu.Text =FisNumarasiGetir();
            txtBelgeNo.Text = satisBilgisi.BekleyenFis.BelgeNo;
            txtAciklama.Text = satisBilgisi.BekleyenFis.Aciklama;
            txtCariKodu.Text = satisBilgisi.BekleyenFis.Cari.CariKodu;
            txtCariAdi.Text = satisBilgisi.BekleyenFis.Cari.CariAdi;
            if (satisBilgisi.BekleyenFis.CariId != null)
            {
                entityBakiye = cariDal.CariBakiyesi(context, Convert.ToInt32(satisBilgisi.BekleyenFis.CariId));
                lblAlacak.Text = entityBakiye.Alacak.ToString("C2");
                lblBorc.Text = entityBakiye.Borc.ToString("C2");
                lblBakiye.Text = entityBakiye.Bakiye.ToString("C2");
            }

            if (satisBilgisi.BekleyenFis.PlasiyerId != null)
            {
                var button = (CheckButton)flowPersonel.Controls.Find(satisBilgisi.BekleyenFis.Personel.PersonelKodu, false).SingleOrDefault();
                button.Checked = true;
            }
            else
            {
                var button = (CheckButton)flowPersonel.Controls.Find("Temizle", false).SingleOrDefault();
                button.Checked = true;
            }

            txtFaturaUnvani.Text = satisBilgisi.BekleyenFis.FaturaUnvani;
            txtVergiDairesi.Text = satisBilgisi.BekleyenFis.VergiDairesi;
            txtVergiNo.Text = satisBilgisi.BekleyenFis.VergiNo;
            txtCepTelefonu.Text = satisBilgisi.BekleyenFis.CepTelefonu;
            txtIl.Text = satisBilgisi.BekleyenFis.Il;
            txtIlce.Text = satisBilgisi.BekleyenFis.Ilce;
            txtSemt.Text = satisBilgisi.BekleyenFis.Semt;
            txtAdres.Text = satisBilgisi.BekleyenFis.Adres;

            txtIskontoOrani.Value = satisBilgisi.BekleyenFis.IskontoOrani ?? 0;
            foreach (var item in satisBilgisi.StokHareketi)
            {
                context.StokHareketleri.Local.Add(item);
            }
            foreach (var item in satisBilgisi.KasaHareketi)
            {
                context.KasaHareketleri.Local.Add(item);
            }
            cagirilanSatisId = Id;
            Toplamlar();
            OdenenTutarGuncelle();
            var buton = (SimpleButton)flowBekleyenSatis.Controls.Find(Convert.ToString(Id), false).SingleOrDefault();
            if (buton != null)
            {
                buton.Text = txtCariKodu.Text + " - " + txtCariAdi.Text + "\n" + _fisEntity.Personel.PersonelKodu + " - " + _fisEntity.Personel.PersonelAdi + "\n" + context.StokHareketleri.Local.Count + " " + "Adet Ürün Eklendi." + "\n" + txtToplam.Value.ToString("C2");
            }
        }

        private void FrmFrontOffice_Load(object sender, EventArgs e)
        {
            txtFisKodu.Text = FisNumarasiGetir();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            FisiKaydet(ReportsPrintTool.Belge.Diger);
            FisTemizle();
        }

        private void repoSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Veriyi Silmek İstediğinize Eminmisiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                gridStokHareket.DeleteSelectedRows();
                Toplamlar();
            }
        }

        private void gridContStokHareket_Click(object sender, EventArgs e)
        {

        }

        private void repoOHSil_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Veriyi Silmek İstediğinize Eminmisiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                gridKasaHareket.DeleteSelectedRows();
                Toplamlar();
            }
        }

        private void repoDepoSecim_Click(object sender, EventArgs e)
        {
            FrmDepoSec form = new FrmDepoSec(Convert.ToInt32(gridStokHareket.GetFocusedRowCellValue(colStokId)));
            form.ShowDialog();
            if (form.secildi)
            {
                gridStokHareket.SetFocusedRowCellValue(colDepoId, form.entity.Id);
                context.ChangeTracker.DetectChanges();
            }
        }

        private void repoSeriNo_Click(object sender, EventArgs e)
        {
            string veri = Convert.ToString(gridStokHareket.GetFocusedRowCellValue(colSeriNo));
            FrmSeriNoGir form = new FrmSeriNoGir(veri, false);
            form.ShowDialog();
            gridStokHareket.SetFocusedRowCellValue(colSeriNo, form.veriSeriNo);
        }

        private void repoBirimFiyat_Click(object sender, EventArgs e)
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

        private void repoKasa_Click(object sender, EventArgs e)
        {
        }

        private string FisNumarasiGetir()
        {
            int sonfisnumarasi = int.Parse(SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_FisKodu));

            var fisnumarasi = CodeTool.KodOlustur("FI", (sonfisnumarasi + 1).ToString());
            return fisnumarasi;
        }
    }
}

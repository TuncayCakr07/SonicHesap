using DevExpress.XtraEditors;
using DevExpress.XtraWizard;
using SonicHesap.Entities.Context;
using SonicHesap.Entities.Data_Access;
using SonicHesap.Entities.Tables;
using SonicHesap.Entities.Tables.OtherTables;
using SonicHesap.Entities.Tools;
using SonicHesap.Entities.Tools.LoadingTool;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SonicHesap.Admin
{
    public partial class FrmDevir : DevExpress.XtraEditors.XtraForm
    {
        SonicHesapContext kaynakContext;
        SqlConnectionStringBuilder connKaynak = new SqlConnectionStringBuilder();
        SonicHesapContext hedefContext;
        SqlConnectionStringBuilder connHedef = new SqlConnectionStringBuilder();
        List<string> dbList;
        CodeTool kodOlustur;
        LoadingTool yuklemeFormu;
        public FrmDevir()
        {
            InitializeComponent();
            yuklemeFormu = new LoadingTool(this);
            kodOlustur = new CodeTool();
            connKaynak.DataSource = "(localdb)\\Tuncay";
            connKaynak.InitialCatalog = "master";
            connKaynak.IntegratedSecurity = true;
            kaynakContext = new SonicHesapContext(connKaynak.ConnectionString);
            dbList = kaynakContext.Database.SqlQuery<string>("Select name From master.dbo.sysdatabases Where name like 'SonicHesap%'").ToList();
            KaynakDbYukle();
            HedefDbYukle();
        }
        private void KaynakDbYukle()
        {
            foreach (var item in dbList)
            {
                CheckButton buton = new CheckButton
                {
                    Name = item,
                    Text = item.Replace("SonicHesap", ""),
                    GroupIndex = 1,
                    Height = 150,
                    Width = 150,
                };
                buton.ImageOptions.ImageList = ımageList1;
                buton.ImageOptions.ImageIndex = 1;
                buton.ImageOptions.ImageToTextAlignment = ImageAlignToText.TopCenter;
                buton.Click += KaynakSec;
                flowKaynak.Controls.Add(buton);
            }
        }

        private void KaynakSec(object sender, EventArgs e)
        {
            CheckButton buton = (CheckButton)sender;
            connKaynak.DataSource = "(localdb)\\Tuncay";
            connKaynak.InitialCatalog = "SonicHesap" + buton.Text;
            connKaynak.IntegratedSecurity = true;
            kaynakContext = new SonicHesapContext(connKaynak.ConnectionString);
        }

        private void HedefDbYukle()
        {
            SimpleButton YeniEkle = new SimpleButton
            {
                Name = "YeniDonemEkle",
                Text = "Yeni Dönem Ekle",
                Height = 150,
                Width = 150,
            };

            YeniEkle.ImageOptions.ImageList = ımageList1;
            YeniEkle.ImageOptions.ImageIndex = 0;
            YeniEkle.ImageOptions.ImageToTextAlignment = ImageAlignToText.TopCenter;
            YeniEkle.Click += YeniDonemEkle;
            flowHedef.Controls.Add(YeniEkle);
            foreach (var item in dbList)
            {
                CheckButton buton = new CheckButton
                {
                    Name = item,
                    Text = item.Replace("SonicHesap", ""),
                    GroupIndex = 2,
                    Height = 150,
                    Width = 150,
                };
                buton.ImageOptions.ImageList = ımageList1;
                buton.ImageOptions.ImageIndex = 0;
                buton.ImageOptions.ImageToTextAlignment = ImageAlignToText.TopCenter;
                buton.Click += HedefSec;
                flowHedef.Controls.Add(buton);
            }
        }

        private void YeniDonemEkle(object sender, EventArgs e)
        {
            SimpleButton butonDonem = (SimpleButton)sender;
            FrmDonemSec form = new FrmDonemSec();
            form.ShowDialog();
            if (!String.IsNullOrEmpty(form.donem))
            {
                yuklemeFormu.AnimasyonBaslat();
                if (!dbList.Contains("SonicHesap" + form.donem))
                {
                    dbList.Add("SonicHesap" + form.donem);
                    CheckButton buton = new CheckButton
                    {
                        Name = "SonicHesap" + form.donem,
                        Text = form.donem,
                        GroupIndex = 2,
                        Height = 150,
                        Width = 150,
                    };
                    buton.ImageOptions.ImageList = ımageList1;
                    buton.ImageOptions.ImageIndex = 0;
                    buton.ImageOptions.ImageToTextAlignment = ImageAlignToText.TopCenter;
                    buton.Click += HedefSec;
                    flowHedef.Controls.Add(buton);
                    connHedef.DataSource = "(localdb)\\Tuncay";
                    connHedef.InitialCatalog = "SonicHesap" + buton.Text;
                    connHedef.IntegratedSecurity = true;
                    hedefContext = new SonicHesapContext(connHedef.ConnectionString);
                    hedefContext.Database.CreateIfNotExists();
                    yuklemeFormu.AnimasyonBitir();
                }
              
                else
                {
                    MessageBox.Show("Seçtiğiniz Dönem Zaten Oluşturulmuştur!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void HedefSec(object sender, EventArgs e)
        {
            CheckButton buton = (CheckButton)sender;
            connHedef.DataSource = "(localdb)\\Tuncay";
            connHedef.InitialCatalog = "SonicHesap" + buton.Text;
            connHedef.IntegratedSecurity = true;
            hedefContext = new SonicHesapContext(connHedef.ConnectionString);
        }

        private void toggleStokAktar_Toggled(object sender, EventArgs e)
        {
            if (toggleStokAktar.IsOn)
            {
                toggleStokHareketAktar.Enabled = true;
                toggleStokGirisCikisAktar.Enabled = true;
                toggleIndirimAktar.Enabled = true;
                toggleHizliSatisAktar.Enabled = true;
            }
            else
            {
                toggleStokHareketAktar.Enabled = false;
                toggleStokGirisCikisAktar.Enabled = false;
                toggleIndirimAktar.Enabled = false;
                toggleHizliSatisAktar.Enabled = false;
            }
        }

        private void toggleCariAktar_Toggled(object sender, EventArgs e)
        {
            if (toggleCariAktar.IsOn)
            {
                toggleCariBakiyeAktar.Enabled = true;
                toggleCariBorcAktar.Enabled = true;
            }
            else
            {
                toggleCariBakiyeAktar.Enabled = false;
                toggleCariBorcAktar.Enabled = false;
            }
        }

        private void toggleKasaAktar_Toggled(object sender, EventArgs e)
        {
            if (toggleKasaAktar.IsOn)
            {
                LookUpKasa.Enabled = true;
            }
            else
            {
                LookUpKasa.Enabled = false;
            }
        }

        private void toggleDepoAktar_Toggled(object sender, EventArgs e)
        {
            if (toggleDepoAktar.IsOn)
            {
                lookupDepo.Enabled = true;
            }
            else
            {
                lookupDepo.Enabled = false;
            }
        }

        private void toggleOdemeTuruAktar_Toggled(object sender, EventArgs e)
        {
            if (toggleOdemeTuruAktar.IsOn)
            {
                gridLookUpOdeme.Enabled = true;
            }
            else
            {
                gridLookUpOdeme.Enabled = false;
            }
        }

        private void wizardControl1_FinishClick(object sender, CancelEventArgs e)
        {
            DevirYap();
        }
        private void DevirYap()
        {
            Kasa Yenikasa = new Kasa();
            Depo YeniDepo = new Depo();
            OdemeTuru YeniOdeme = new OdemeTuru();
            //Kasa Aktarımı
            if (toggleKasaAktar.IsOn)
            {
                foreach (var item in kaynakContext.Kasalar.AsNoTracking().ToList())
                {
                    hedefContext.Kasalar.Add(item);
                }
            }
            else
            {
                Yenikasa.KasaKodu = "01";
                Yenikasa.KasaAdi = "Merkez Kasa";
                hedefContext.Kasalar.Add(Yenikasa);

            }

            //Depo Aktarımı
            if (toggleDepoAktar.IsOn)
            {
                foreach (var item in kaynakContext.Depolar.AsNoTracking().ToList())
                {
                    hedefContext.Depolar.Add(item);
                }
            }
            else
            {
               
                YeniDepo.DepoKodu = "01";
                YeniDepo.DepoAdi = "Merkez Depo";
                hedefContext.Depolar.Add(YeniDepo);

            }
            hedefContext.SaveChanges();

            //Ödeme Türü Aktarımı
            if (toggleOdemeTuruAktar.IsOn)
            {
                foreach (var item in kaynakContext.OdemeTurleri.AsNoTracking().ToList())
                {
                    hedefContext.OdemeTurleri.Add(item);
                }
            }
            else
            {
               
                YeniOdeme.OdemeTuruKodu = "01";
                YeniOdeme.OdemeTuruAdi = "Nakit";
                hedefContext.OdemeTurleri.Add(YeniOdeme);

            }
            //Tanım Aktarımı
            if (toggleTanımAktar.IsOn)
            {
                foreach (var item in kaynakContext.Tanimlar.AsNoTracking().ToList())
                {
                    hedefContext.Tanimlar.Add(item);
                }
            }
            //Kod Aktarımı
            if (toggleKodAktar.IsOn)
            {
                foreach (var item in kaynakContext.Kodlar.AsNoTracking().ToList())
                {
                    hedefContext.Kodlar.Add(item);
                }
            }
            //Ajanda Aktarımı
            if (toggleAjandaAktar.IsOn)
            {
                foreach (var item in kaynakContext.EFAppointments.AsNoTracking().ToList())
                {
                    hedefContext.EFAppointments.Add(item);
                }
                foreach (var item in kaynakContext.EFResources.AsNoTracking().ToList())
                {
                    hedefContext.EFResources.Add(item);
                }
            }
            //Kullanıcıları Aktarma
            if (toggleKullaniciAktar.IsOn)
            {
                foreach (var item in kaynakContext.Kullanicilar.AsNoTracking().ToList())
                {
                    hedefContext.Kullanicilar.Add(item);
                }
                foreach (var item in kaynakContext.KullaniciRolleri.AsNoTracking().ToList())
                {
                    hedefContext.KullaniciRolleri.Add(item);
                }
            }

            //Stok Aktarımı
            if (toggleStokAktar.IsOn)
            {
                StokDAL stokDal = new StokDAL();
                //Indirim Aktarımı
                if (toggleIndirimAktar.IsOn)
                {
                    foreach (var item in kaynakContext.Indirimler.AsNoTracking().ToList())
                    {
                        hedefContext.Indirimler.Add(item);
                    }
                }

                //Hızlı Satış Aktarımı
                if (toggleHizliSatisAktar.IsOn)
                {
                    foreach (var item in kaynakContext.HizliSatisGruplari.AsNoTracking().ToList())
                    {
                        hedefContext.HizliSatisGruplari.Add(item);
                    }
                    foreach (var item in kaynakContext.HizliSatislar.AsNoTracking().ToList())
                    {
                        hedefContext.HizliSatislar.Add(item);
                    }
                }
                foreach (var item in kaynakContext.Stoklar.AsNoTracking().ToList())
                {
                    hedefContext.Stoklar.Add(item);
                    if (toggleStokHareketAktar.IsOn && toggleStokGirisCikisAktar.IsOn)
                    {
                        StokBakiye bakiye = stokDal.StokBakiyesi(kaynakContext, item.Id);
                        if (bakiye.MevcutStok != 0)
                        {

                            Fis stokDevir = new Fis();
                            stokDevir.FisTuru = "Stok Devir Fişi";
                            stokDevir.FisKodu = CodeTool.YeniFisOdemeKodu();
                            stokDevir.Tarih = DateTime.Now;
                            stokDevir.ToplamTutar = Math.Abs(bakiye.MevcutStok) * item.AlisFiyati1;
                            hedefContext.fisler.Add(stokDevir);
                            StokHareket hareket = new StokHareket();
                            hareket.StokId = item.Id;
                            hareket.Hareket = bakiye.MevcutStok < 0 ? "Stok Çıkış" : "Stok Giriş";
                            hareket.Miktar = Math.Abs(bakiye.MevcutStok);
                            hareket.FisKodu = stokDevir.FisKodu;
                            hareket.BirimFiyati = item.AlisFiyati1;
                            hareket.Kdv = item.AlisKdv;
                            hareket.Tarih = DateTime.Now;
                            hareket.DepoId = toggleDepoAktar.IsOn ? Convert.ToInt32(lookupDepo.EditValue) : YeniDepo.Id;
                            hedefContext.StokHareketleri.Add(hareket);
                        }
                    }
                    else
                    {
                        StokBakiye bakiye = stokDal.StokBakiyesi(kaynakContext, item.Id);
                        if (bakiye.MevcutStok != 0)
                        {
                            //Stok Giriş
                            Fis stokDevir = new Fis();
                            StokHareket hareketGiris = new StokHareket();

                            stokDevir.FisTuru = "Stok Devir Fişi";
                            stokDevir.FisKodu = CodeTool.YeniFisOdemeKodu();
                            stokDevir.Tarih = DateTime.Now;
                            stokDevir.ToplamTutar = bakiye.StokGiris * item.AlisFiyati1;
                            hareketGiris.StokId = item.Id;
                            hareketGiris.Hareket = "Stok Giriş";
                            hareketGiris.Miktar = bakiye.StokGiris;
                            hareketGiris.FisKodu = stokDevir.FisKodu;
                            hareketGiris.BirimFiyati = item.AlisFiyati1;
                            hareketGiris.Kdv = item.AlisKdv;
                            hareketGiris.Tarih = DateTime.Now;
                            hareketGiris.DepoId = toggleDepoAktar.IsOn ? Convert.ToInt32(lookupDepo.EditValue) : YeniDepo.Id;
                            if (bakiye.StokGiris > 0)
                            {
                                hedefContext.fisler.Add(stokDevir);
                                hedefContext.StokHareketleri.Add(hareketGiris);
                            }

                            //Stok Çıkış
                            if (bakiye.StokCikis > 0)
                            {
                                Fis stokCikisDevir = stokDevir.Clone();
                                stokCikisDevir.FisKodu = CodeTool.YeniFisOdemeKodu();
                                stokCikisDevir.ToplamTutar = bakiye.StokCikis * item.AlisFiyati1;
                                hedefContext.fisler.Add(stokCikisDevir);

                                StokHareket hareketCikis = hareketGiris.Clone();
                                hareketCikis.FisKodu = stokCikisDevir.FisKodu;
                                hareketCikis.Hareket = "Stok Çıkış";
                                hareketCikis.Miktar = bakiye.StokCikis;
                                hedefContext.StokHareketleri.Add(hareketCikis);
                            }


                        }
                    }
                }
            }
            //Cari Aktarımı
            if (toggleCariAktar.IsOn)
            {
                foreach (var item in kaynakContext.Cariler.AsNoTracking().ToList())
                {
                    hedefContext.Cariler.Add(item);
                    CariDAL cariDAL = new CariDAL();
                    CariBakiye bakiye = cariDAL.CariBakiyesi(kaynakContext, item.Id);
                    if (toggleCariBakiyeAktar.IsOn && toggleCariBorcAktar.IsOn)
                    {
                       
                        if (bakiye.Bakiye != 0)
                        {
                            Fis cariDevir = new Fis();
                            cariDevir.CariId = item.Id;
                            cariDevir.FisTuru = "Cari Devir Fişi";
                            cariDevir.Tarih = DateTime.Now;
                            cariDevir.FisKodu = CodeTool.YeniFisOdemeKodu();
                            cariDevir.ToplamTutar = Math.Abs(bakiye.Bakiye);
                            if (bakiye.Bakiye < 0)
                            {
                                cariDevir.Borc = Math.Abs(bakiye.Bakiye);
                                cariDevir.Alacak = null;
                                hedefContext.fisler.Add(cariDevir);
                                KasaHareket kasaBorc = new KasaHareket();
                                kasaBorc.FisKodu = cariDevir.FisKodu;
                                kasaBorc.CariId = item.Id;
                                kasaBorc.Hareket = "Kasa Çıkış";
                                kasaBorc.KasaId = toggleKasaAktar.IsOn ? Convert.ToInt32(LookUpKasa.EditValue) : Yenikasa.Id;
                                kasaBorc.OdemeTuruId = toggleOdemeTuruAktar.IsOn ? Convert.ToInt32(gridLookUpOdeme.EditValue) : YeniOdeme.Id;
                                kasaBorc.Tarih = DateTime.Now;
                                kasaBorc.Tutar = Math.Abs(bakiye.Bakiye);
                                hedefContext.KasaHareketleri.Add(kasaBorc);
                            }
                            else
                            {
                                cariDevir.Alacak = Math.Abs(bakiye.Bakiye);
                                cariDevir.Borc = null;
                                hedefContext.fisler.Add(cariDevir);
                                KasaHareket kasaAlacak = new KasaHareket();
                                kasaAlacak.FisKodu = cariDevir.FisKodu;
                                kasaAlacak.CariId = item.Id;
                                kasaAlacak.Hareket = "Kasa Giriş";
                                kasaAlacak.KasaId = toggleKasaAktar.IsOn ? Convert.ToInt32(LookUpKasa.EditValue) : Yenikasa.Id;
                                kasaAlacak.OdemeTuruId = toggleOdemeTuruAktar.IsOn ? Convert.ToInt32(gridLookUpOdeme.EditValue) : YeniOdeme.Id;
                                kasaAlacak.Tarih = DateTime.Now;
                                kasaAlacak.Tutar = Math.Abs(bakiye.Bakiye);
                                hedefContext.KasaHareketleri.Add(kasaAlacak);
                            }
                        }
                    }
                    else if (toggleCariBakiyeAktar.IsOn && !toggleCariBorcAktar.IsOn)
                    {
                        if (bakiye.Alacak!=0)
                        {
                            Fis alacakFis = new Fis();
                            alacakFis.CariId = item.Id;
                            alacakFis.FisTuru = "Cari Devir Fişi";
                            alacakFis.Tarih = DateTime.Now;
                            alacakFis.FisKodu = CodeTool.YeniFisOdemeKodu();
                            alacakFis.Borc = null;
                            alacakFis.Alacak = bakiye.Alacak;
                            alacakFis.ToplamTutar = bakiye.Alacak;
                            hedefContext.fisler.Add(alacakFis);
                            KasaHareket kasaAlacak = new KasaHareket();
                            kasaAlacak.FisKodu = alacakFis.FisKodu;
                            kasaAlacak.CariId = item.Id;
                            kasaAlacak.Hareket = "Kasa Giriş";
                            kasaAlacak.KasaId = toggleKasaAktar.IsOn ? Convert.ToInt32(LookUpKasa.EditValue) : Yenikasa.Id;
                            kasaAlacak.OdemeTuruId = toggleOdemeTuruAktar.IsOn ? Convert.ToInt32(gridLookUpOdeme.EditValue) : YeniOdeme.Id;
                            kasaAlacak.Tarih = DateTime.Now;
                            kasaAlacak.Tutar = Math.Abs(bakiye.Alacak);
                            hedefContext.KasaHareketleri.Add(kasaAlacak);
                        }

                        if (bakiye.Borc!=0)
                        {
                            Fis borcFis = new Fis();
                            borcFis.CariId = item.Id;
                            borcFis.FisTuru = "Cari Devir Fişi";
                            borcFis.Tarih = DateTime.Now;
                            borcFis.FisKodu = CodeTool.YeniFisOdemeKodu();
                            borcFis.Borc = bakiye.Borc;
                            borcFis.Alacak = null;
                            borcFis.ToplamTutar = bakiye.Alacak;
                            hedefContext.fisler.Add(borcFis);
                            KasaHareket kasaBorc = new KasaHareket();
                            kasaBorc.FisKodu = borcFis.FisKodu;
                            kasaBorc.CariId = item.Id;
                            kasaBorc.Hareket = "Kasa Çıkış";
                            kasaBorc.KasaId = toggleKasaAktar.IsOn ? Convert.ToInt32(LookUpKasa.EditValue) : Yenikasa.Id;
                            kasaBorc.OdemeTuruId = toggleOdemeTuruAktar.IsOn ? Convert.ToInt32(gridLookUpOdeme.EditValue) : YeniOdeme.Id;
                            kasaBorc.Tarih = DateTime.Now;
                            kasaBorc.Tutar = Math.Abs(bakiye.Borc);
                            hedefContext.KasaHareketleri.Add(kasaBorc);
                        }
                    }
                }
            }

            if (togglePersonelAktar.IsOn)
            {
                foreach (var item in kaynakContext.Personeller.AsNoTracking().ToList())
                {
                    hedefContext.Personeller.Add(item);
                }
            }

            hedefContext.SaveChanges();
        }

        private void wizardControl1_SelectedPageChanging(object sender, DevExpress.XtraWizard.WizardPageChangingEventArgs e)
        {
            if (e.Page == wizardPage2 && e.Direction == Direction.Forward)
            {
                lookupDepo.Properties.DataSource = kaynakContext.Depolar.AsNoTracking().ToList();
                LookUpKasa.Properties.DataSource = kaynakContext.Kasalar.AsNoTracking().ToList();
                gridLookUpOdeme.Properties.DataSource = kaynakContext.OdemeTurleri.AsNoTracking().ToList();
            }
        }
    }
}
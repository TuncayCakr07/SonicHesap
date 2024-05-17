using DevExpress.XtraEditors;
using DevExpress.XtraWizard;
using SonicHesap.Entities.Context;
using SonicHesap.Entities.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        SqlConnectionStringBuilder connKaynak= new SqlConnectionStringBuilder();
        SonicHesapContext hedefContext;
        SqlConnectionStringBuilder connHedef = new SqlConnectionStringBuilder();
        List<string> dbList;
        public FrmDevir()
        {
            InitializeComponent();
            connKaynak.DataSource = "(localdb)\\Tuncay";
            connKaynak.InitialCatalog = "master";
            connKaynak.IntegratedSecurity = true;
            kaynakContext=new SonicHesapContext(connKaynak.ConnectionString);
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
                    Text = item.Replace("SonicHesap",""),
                    GroupIndex = 1,
                    Height = 150,
                    Width = 150,
                };
                buton.Click += KaynakSec;
                flowKaynak.Controls.Add(buton);
            }
        }

        private void KaynakSec(object sender, EventArgs e)
        {
           CheckButton buton=(CheckButton)sender;
            connKaynak.DataSource = "(localdb)\\Tuncay";
            connKaynak.InitialCatalog = "SonicHesap"+buton.Text;
            connKaynak.IntegratedSecurity = true;
            kaynakContext = new SonicHesapContext(connKaynak.ConnectionString);
        }

        private void HedefDbYukle()
        {
            SimpleButton YeniEkle = new SimpleButton
            {
                Name="YeniDonemEkle",
                Text="Yeni Dönem Ekle",
                Height=150,
                Width=150,
            };
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
                buton.Click += HedefSec;
                flowHedef.Controls.Add(buton);
            }
        }

        private void YeniDonemEkle(object sender, EventArgs e)
        {
            SimpleButton butonDonem = (SimpleButton)sender;
            FrmDonemSec form=new FrmDonemSec();
            form.ShowDialog();
            if (!String.IsNullOrEmpty(form.donem))
            {
                if (!dbList.Contains("SonicHesap"+form.donem))
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
                    buton.Click += HedefSec;
                    flowHedef.Controls.Add(buton);
                    connHedef.DataSource = "(localdb)\\Tuncay";
                    connHedef.InitialCatalog = "SonicHesap" + buton.Text;
                    connHedef.IntegratedSecurity = true;
                    hedefContext = new SonicHesapContext(connHedef.ConnectionString);
                    hedefContext.Database.CreateIfNotExists();
                }
                else
                {
                    MessageBox.Show("Seçtiğiniz Dönem Zaten Oluşturulmuştur!","Uyarı!",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
                Kasa Yenikasa=new Kasa();
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
                Depo YeniDepo = new Depo();
                YeniDepo.DepoKodu = "01";
                YeniDepo.DepoAdi = "Merkez Depo";
                hedefContext.Depolar.Add(YeniDepo);

            }

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
                OdemeTuru YeniOdeme = new OdemeTuru();
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
            hedefContext.SaveChanges();
        }

        private void wizardControl1_SelectedPageChanging(object sender, DevExpress.XtraWizard.WizardPageChangingEventArgs e)
        {
            if (e.Page==wizardPage2 && e.Direction==Direction.Forward)
            {
                lookupDepo.Properties.DataSource = kaynakContext.Depolar.AsNoTracking().ToList();
                LookUpKasa.Properties.DataSource = kaynakContext.Kasalar.AsNoTracking().ToList();
                gridLookUpOdeme.Properties.DataSource = kaynakContext.OdemeTurleri.AsNoTracking().ToList();
            }
        }
    }
}
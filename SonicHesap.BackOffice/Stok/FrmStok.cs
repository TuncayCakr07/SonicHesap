using DevExpress.XtraEditors;
using SonicHesap.Entities.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SonicHesap.BackOffice.Stok
{
    public partial class FrmStok : DevExpress.XtraEditors.XtraForm
    {
        SonicHesapContext context=new SonicHesapContext();
        public FrmStok()
        {
            InitializeComponent();
        }

        private void FrmStok_Load(object sender, EventArgs e)
        {

        }
        public void GetAll() 
        {
            var table = context.Stoklar.GroupJoin(context.StokHareketleri, c => c.StokKodu, c => c.StokKodu, (Stoklar, StokHareketleri) => 
            new 
            {
                Stoklar.Id,
                Stoklar.Durumu,
                Stoklar.StokKodu,
                Stoklar.StokAdi,
                Stoklar.Barkod,
                Stoklar.BarkodTuru,
                Stoklar.Birimi,
                Stoklar.StokGrubu,
                Stoklar.StokAltGrubu,
                Stoklar.Marka,
                Stoklar.Modeli,
                Stoklar.OzelKod1,
                Stoklar.OzelKod2,
                Stoklar.OzelKod3,
                Stoklar.OzelKod4,
                Stoklar.GarantiSuresi,
                Stoklar.UreticiKodu,
                Stoklar.AlisKdv,
                Stoklar.SatisKdv,
                Stoklar.AlisFiyati1,
                Stoklar.AlisFiyati2,
                Stoklar.AlisFiyati3,
                Stoklar.SatisFiyati1,
                Stoklar.SatisFiyati2,
                Stoklar.SatisFiyati3,
                Stoklar.MinStokMiktarı,
                Stoklar.MaxStokMiktarı,
                Stoklar.Aciklama,
                StokGiris=StokHareketleri.Where(c=>c.Hareket=="Stok Giriş").Sum(c=>c.ToplamTutar),
                StokCikis= StokHareketleri.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.ToplamTutar),
                MevcutStok= StokHareketleri.Where(c => c.Hareket == "Stok Giriş").Sum(c => c.ToplamTutar)- StokHareketleri.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.ToplamTutar),
            }).ToList();
            gridControl1.DataSource = table;
        }

    }
}
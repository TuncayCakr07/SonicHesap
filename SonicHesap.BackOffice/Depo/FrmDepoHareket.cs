using DevExpress.XtraEditors;
using SonicHesap.Entities.Context;
using SonicHesap.Entities.Data_Access;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SonicHesap.BackOffice.Depo
{
    public partial class FrmDepoHareket : DevExpress.XtraEditors.XtraForm
    {
        SonicHesapContext context=new SonicHesapContext();
        StokHareketDAL stokhareketDal= new StokHareketDAL();
        string _depoKodu;
        public FrmDepoHareket(string depoKodu,string depoAdi)
        {
            InitializeComponent();
            _depoKodu = depoKodu;
            lblBaslik.Text = depoKodu + " - " + depoAdi + "Hareketleri";
        }

        private void FrmDepoHareket_Load(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void Guncelle()
        {
            gridContHareket.DataSource = stokhareketDal.GetAll(context, c => c.DepoKodu == _depoKodu);
            gridContDepoStokMiktar.DataSource = stokhareketDal.DepoStokListele(context,_depoKodu);
            gridContİstatistik.DataSource=stokhareketDal.DepoIstatistikListele(context,_depoKodu);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (gridHareket.OptionsView.ShowAutoFilterRow == true)
            {
                gridHareket.OptionsView.ShowAutoFilterRow = false;
            }
            else
            {
                gridHareket.OptionsView.ShowAutoFilterRow = true;
            }
        }

        private void lblBaslik_Click(object sender, EventArgs e)
        {

        }
    }
}
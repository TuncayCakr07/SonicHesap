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

namespace SonicHesap.BackOffice.Stok
{
    public partial class FrmStokHareket : DevExpress.XtraEditors.XtraForm
    {
        StokHareketDAL hareketDal=new StokHareketDAL();
        SonicHesapContext context = new SonicHesapContext();
        private int _stokId;
        public FrmStokHareket(int stokId)
        {
            InitializeComponent();
            _stokId = stokId;
            var stok=context.Stoklar.SingleOrDefault(c=>c.Id==stokId);
            lblBaslik.Text = stok.StokKodu + "-" + stok.StokAdi + "Hareketleri";
        }

        private void FrmStokHareket_Load(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void Guncelle()
        {
            gridContStokHareket.DataSource = hareketDal.GetAll(context, c => c.Id == _stokId);
            gridContGenelStok.DataSource = hareketDal.GetGenelStok(context, _stokId);
            gridContDepoStok.DataSource = hareketDal.GetDepoStok(context, _stokId);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (gridStokHareket.OptionsView.ShowAutoFilterRow == true)
            {
                gridStokHareket.OptionsView.ShowAutoFilterRow = false;
            }
            else
            {
                gridStokHareket.OptionsView.ShowAutoFilterRow = true;
            }
        }
    }
}
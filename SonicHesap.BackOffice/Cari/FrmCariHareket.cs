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

namespace SonicHesap.BackOffice.Cari
{
    public partial class FrmCariHareket : DevExpress.XtraEditors.XtraForm
    {
        CariDAL cariDAL=new CariDAL();
        SonicHesapContext context=new SonicHesapContext();
        private int _cariId;
        public FrmCariHareket(int cariId)
        {
            InitializeComponent();
            _cariId = cariId;
            var cariEntity=cariDAL.GetByFilter(context,c=>c.Id==cariId);
            lblBaslik.Text = cariEntity.CariKodu + "-" + cariEntity.CariAdi +" "+"Hareketleri";
        }

        private void FrmCariHareket_Load(object sender, EventArgs e)
        {
            Guncelle();
        }
        private void Guncelle()
        {
            gridContFisToplam.DataSource = cariDAL.CariFisGenelToplam(context,_cariId);
            gridContBakiye.DataSource=cariDAL.CariFisGenelToplam(context, _cariId);
            gridContCariHareket.DataSource = cariDAL.CariFisAyrinti(context, _cariId);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (gridCariHareket.OptionsView.ShowAutoFilterRow == true)
            {
                gridCariHareket.OptionsView.ShowAutoFilterRow = false;
            }
            else
            {
                gridCariHareket.OptionsView.ShowAutoFilterRow = true;
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
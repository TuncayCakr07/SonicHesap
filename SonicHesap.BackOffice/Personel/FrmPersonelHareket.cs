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

namespace SonicHesap.BackOffice.Personel
{
    public partial class FrmPersonelHareket : DevExpress.XtraEditors.XtraForm
    {
        SonicHesapContext context=new SonicHesapContext();
        PersonelDAL personelDal= new PersonelDAL(); 
        FisDAL fisDAL = new FisDAL();
        private string _personelKodu;
        public FrmPersonelHareket(string personelKodu,string personelAdi)
        {
            InitializeComponent();
            _personelKodu = personelKodu;
            lblBaslik.Text = personelKodu + " - " + personelAdi;
        }

        private void FrmPersonelHareket_Load(object sender, EventArgs e)
        {
            Listele();
        }
        private void Listele()
        {
            gridContPersonelHareket.DataSource = fisDAL.GetAll(context, c => c.PlasiyerKodu == _personelKodu);
            gridContFisToplam.DataSource = personelDal.PersonelFisToplam(context, _personelKodu);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            gridPersonelHareket.OptionsView.ShowAutoFilterRow = true ? gridPersonelHareket.OptionsView.ShowAutoFilterRow==false : gridPersonelHareket.OptionsView.ShowAutoFilterRow==true;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
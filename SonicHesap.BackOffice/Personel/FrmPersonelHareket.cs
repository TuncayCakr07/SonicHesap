using DevExpress.XtraEditors;
using SonicHesap.Entities.Context;
using SonicHesap.Entities.Data_Access;
using SonicHesap.Entities.Tables;
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
        private int _personelId;
        public FrmPersonelHareket(int personelId)
        {
            InitializeComponent();
            _personelId = personelId;
            var personelBilgi=context.Personeller.SingleOrDefault(c=>c.Id==personelId);
            lblBaslik.Text = personelBilgi.PersonelKodu + " - " + personelBilgi.PersonelAdi;
        }

        private void FrmPersonelHareket_Load(object sender, EventArgs e)
        {
            Listele();
        }
        private void Listele()
        {
            gridContPersonelHareket.DataSource = fisDAL.GetAll(context, c => c.PlasiyerId == _personelId);
            gridContFisToplam.DataSource = personelDal.PersonelFisToplam(context, _personelId);
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
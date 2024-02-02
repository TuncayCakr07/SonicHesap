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
    public partial class FrmPersonel : DevExpress.XtraEditors.XtraForm
    {
        SonicHesapContext context=new SonicHesapContext();
        PersonelDAL personelDal=new PersonelDAL();
        public FrmPersonel()
        {
            InitializeComponent();
        }

        private void Listele()
        {
            gridContPersonelHareket.DataSource = personelDal.PersonelListele(context);
        }

        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
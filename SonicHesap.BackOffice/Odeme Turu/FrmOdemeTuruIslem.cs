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

namespace SonicHesap.BackOffice.Odeme_Turu
{
    public partial class FrmOdemeTuruIslem : DevExpress.XtraEditors.XtraForm
    {
        SonicHesapContext context=new SonicHesapContext();
        OdemeTuruDAL OdemeTuruDal=new OdemeTuruDAL();
        private OdemeTuru _entity;
        public FrmOdemeTuruIslem(OdemeTuru entity)
        {
            InitializeComponent();
            _entity = entity;
            txtOdemeKodu.DataBindings.Add("Text", _entity, "OdemeTuruKodu");
            txtOdemeAdi.DataBindings.Add("Text", _entity, "OdemeTuruAdi");
            txtAciklama.DataBindings.Add("Text", _entity, "Aciklama");
        }

        private void FrmOdemeTuruIslem_Load(object sender, EventArgs e)
        {

        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (OdemeTuruDal.AddOrUpdate(context,_entity))
            {
                OdemeTuruDal.Save(context);
                MessageBox.Show("Ödeme Türü Kaydedildi!","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
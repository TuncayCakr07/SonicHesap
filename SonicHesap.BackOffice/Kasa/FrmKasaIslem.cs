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

namespace SonicHesap.BackOffice.Kasa
{
    public partial class FrmKasaIslem : DevExpress.XtraEditors.XtraForm
    {
        KasaDAL kasaDal=new KasaDAL();
        SonicHesapContext context = new SonicHesapContext();
        public bool Kaydedildi=false;
        private Entities.Tables.Kasa _entity;
        public FrmKasaIslem(Entities.Tables.Kasa entity)
        {
            InitializeComponent();
            _entity = entity;
            txtKasaKodu.DataBindings.Add("Text", _entity, "KasaKodu");
            txtKasaAdi.DataBindings.Add("Text", _entity, "KasaAdi");
            txtYetkiliKodu.DataBindings.Add("Text", _entity, "YetkiliKodu");
            txtYetkiliAdi.DataBindings.Add("Text", _entity, "YetkiliAdi");
            txtAciklama.DataBindings.Add("Text", _entity, "Aciklama");
        }

        private void FrmKasaIslem_Load(object sender, EventArgs e)
        {

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (kasaDal.AddOrUpdate(context,_entity))
            {
                kasaDal.Save(context);
                Kaydedildi = true;
                this.Close(); 
            }
        }
    }
}
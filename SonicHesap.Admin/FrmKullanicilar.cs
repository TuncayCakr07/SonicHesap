using SonicHesap.Entities.Context;
using SonicHesap.Entities.Data_Access;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SonicHesap.Admin
{
    public partial class FrmKullanicilar : DevExpress.XtraEditors.XtraForm
    {
        SonicHesapContext context = new SonicHesapContext();
        KullaniciDAL kullaniciDal = new KullaniciDAL();
        public FrmKullanicilar()
        {
            InitializeComponent();
            Guncelle();
        }

        private void Guncelle()
        {
            gridControl1.DataSource = kullaniciDal.GetAll(context);
        }

        private void FrmKullanicilar_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmKullaniciIslem form=new FrmKullaniciIslem(new Entities.Tables.Kullanici());
            form.ShowDialog();
        }
    }
}

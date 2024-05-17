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
        string secilen;
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
            Guncelle();
            FrmKullaniciGiris form=new FrmKullaniciGiris();
            form.ShowDialog();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmKullaniciIslem form=new FrmKullaniciIslem(new Entities.Tables.Kullanici());
            form.ShowDialog();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            secilen=gridView1.GetFocusedRowCellValue(colKullaniciAdi).ToString();
            FrmKullaniciIslem form=new FrmKullaniciIslem(kullaniciDal.GetByFilter(context,c=>c.KullaniciAdi==secilen));
            form.ShowDialog();
            if (form.saved)
            {
                Guncelle();
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            FrmDevir form=new FrmDevir();
            form.ShowDialog();
        }
    }
}

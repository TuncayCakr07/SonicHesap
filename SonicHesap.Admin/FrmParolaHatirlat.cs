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

namespace SonicHesap.Admin
{
    public partial class FrmParolaHatirlat : DevExpress.XtraEditors.XtraForm
    {
        SonicHesapContext context=new SonicHesapContext();
        KullaniciDAL kullaniciDal = new KullaniciDAL();
        Kullanici _entity;
        public FrmParolaHatirlat(string kullaniciAdi)
        {
            InitializeComponent();
            _entity = context.Kullanicilar.SingleOrDefault(c => c.KullaniciAdi == kullaniciAdi);
            txtHatirlatma.Text = _entity.HatirlatmaSorusu;
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (_entity.Cevap==txtCevap.Text && txtParola.Text==txtParolaTekrar.Text)
            {
                _entity.Parola = txtParola.Text;
                kullaniciDal.AddOrUpdate(context,_entity);
                context.SaveChanges();
                MessageBox.Show("Parola Güncelleme İşleminiz Başarıyla Tamamlanmıştır!", "Parola Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
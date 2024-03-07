using DevExpress.XtraEditors;
using SonicHesap.Entities.Context;
using SonicHesap.Entities.Data_Access;
using SonicHesap.Entities.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SonicHesap.BackOffice.Ayarlar
{
    public partial class FrmAyarlar : DevExpress.XtraEditors.XtraForm
    {
        SonicHesapContext context = new SonicHesapContext();
        DepoDAL depoDAL = new DepoDAL();
        public FrmAyarlar()
        {
            InitializeComponent();
            lookupDepo.Properties.DataSource = depoDAL.GetAll(context);
            lookupDepo.EditValue = SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_VarsayilanDepo);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ayarları kaydetmek istiyor musunuz?", "Ayarları Kaydet", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                SettingsTool.AyarDegistir(SettingsTool.Ayarlar.SatisAyarlari_VarsayilanDepo, lookupDepo.EditValue.ToString());
                SettingsTool.Save();
                MessageBox.Show("Ayarlar başarıyla kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
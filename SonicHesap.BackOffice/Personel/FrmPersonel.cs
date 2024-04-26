using DevExpress.XtraEditors;
using SonicHesap.BackOffice.Cari;
using SonicHesap.BackOffice.Fis;
using SonicHesap.Entities.Context;
using SonicHesap.Entities.Data_Access;
using SonicHesap.Entities.Mapping;
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
        int _secilen;
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

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Both;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            filterControl1.ApplyFilter();
        }

        private void btnFiltreKapat_Click(object sender, EventArgs e)
        {
            filterControl1.FilterString = null;
            filterControl1.ApplyFilter();
        }

        private void btnFormKapat_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            _secilen = Convert.ToInt32(gridPersonelHareket.GetFocusedRowCellValue(colId));

            DialogResult result = MessageBox.Show("Seçili Olan Kaydı Silmek İstediğinize Emin Misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                personelDal.Delete(context, c => c.Id == _secilen);
                personelDal.Save(context);
                MessageBox.Show("Seçili Kayıt Silindi!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmPersonelIslem form = new FrmPersonelIslem(new Entities.Tables.Personel());
            form.ShowDialog();
            if (form.saved)
            {
                Listele();
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            _secilen = Convert.ToInt32(gridPersonelHareket.GetFocusedRowCellValue(colId));
            FrmPersonelIslem form = new FrmPersonelIslem(personelDal.GetByFilter(context, c => c.Id == _secilen));
            form.ShowDialog();
            if (form.saved)
            {
                Listele();
            }
        }

        private void btnPersonelHareket_Click(object sender, EventArgs e)
        {
            _secilen = Convert.ToInt32(gridPersonelHareket.GetFocusedRowCellValue(colId));
            FrmPersonelHareket form = new FrmPersonelHareket(_secilen);
            form.ShowDialog();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FrmFisIslem form = new FrmFisIslem(null,"Hakediş Fişi");
            form.ShowDialog();  
        }
    }
}
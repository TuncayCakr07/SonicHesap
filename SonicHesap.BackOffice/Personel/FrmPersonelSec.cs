using DevExpress.XtraEditors;
using SonicHesap.Entities.Context;
using SonicHesap.Entities.Data_Access;
using SonicHesap.Entities.Mapping;
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
    public partial class FrmPersonelSec : DevExpress.XtraEditors.XtraForm
    {
        PersonelDAL personelDal = new PersonelDAL();
        SonicHesapContext context = new SonicHesapContext();
        public List<Entities.Tables.PersonelHareket> secilen = new List<Entities.Tables.PersonelHareket>();
        public bool secildi = false;
        private DateTime _donem;
        public FrmPersonelSec(DateTime donemi,bool cokluSecim = false)
        {
            InitializeComponent();
            if (cokluSecim)
            {
                lblUyari.Visible = true;
                gridPersonelHareket.OptionsSelection.MultiSelect = true;
            }
            _donem = donemi;
            gridContPersonelHareket.DataSource = personelDal.TarihePersonelListele(context,donemi.Month,donemi.Year);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            if (gridPersonelHareket.GetSelectedRows().Length != 0)
            {
                foreach (var row in gridPersonelHareket.GetSelectedRows())
                {
                    string personelKodu = gridPersonelHareket.GetRowCellValue(row, colPersonelKodu).ToString();
                    secilen.Add(new PersonelHareket
                    {
                        PersonelKodu= gridPersonelHareket.GetRowCellValue(row, colPersonelKodu).ToString(),
                        PersonelAdi = gridPersonelHareket.GetRowCellValue(row, colPersonelAdi).ToString(),
                        TCKimlikNo= gridPersonelHareket.GetRowCellValue(row, colTcKimlikNo).ToString(),
                        Unvani= gridPersonelHareket.GetRowCellValue(row, colUnvani).ToString(),
                        Donemi=_donem,
                        AylikMaasi=Convert.ToDecimal(gridPersonelHareket.GetRowCellValue(row, colAylikMaasi).ToString()),
                        PrimOrani= Convert.ToDecimal(gridPersonelHareket.GetRowCellValue(row, colPrimOrani).ToString()),
                        ToplamSatis= Convert.ToDecimal(gridPersonelHareket.GetRowCellValue(row, colToplamSatis).ToString()),

                    });
                }
                secildi = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Seçilen Bir Cari Bulunamadı!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
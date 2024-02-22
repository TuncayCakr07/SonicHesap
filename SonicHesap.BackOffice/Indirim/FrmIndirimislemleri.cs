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

namespace SonicHesap.BackOffice.Indirim
{
    public partial class FrmIndirimislemleri : DevExpress.XtraEditors.XtraForm
    {
        SonicHesapContext context=new SonicHesapContext();
        IndirimDAL indirimDal= new IndirimDAL();
        public FrmIndirimislemleri()
        {
            InitializeComponent();
            Listele();
        }

        private void Listele()
        {
            gridContIndirim.DataSource = indirimDal.IndirimListele(context);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmIndirimIslem form=new FrmIndirimIslem();
            form.ShowDialog();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SonicHesapContext context = new SonicHesapContext();
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Veriyi Silmek İstediğinize Eminmisiniz?","Uyarı!",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                var secilen=gridIndirim.GetFocusedRowCellValue(colStokKodu).ToString();
                indirimDal.Delete(context, c => c.StokKodu == secilen);
                indirimDal.Save(context);
                MessageBox.Show("Secili Veri Silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDurum_Click(object sender, EventArgs e)
        {
            var secilenStokKodu = gridIndirim.GetFocusedRowCellValue(colStokKodu).ToString();
            var secilen = indirimDal.GetByFilter(context, c => c.StokKodu == secilenStokKodu);
            if (Convert.ToBoolean(gridIndirim.GetFocusedRowCellValue(colDurumu)))
            {
                secilen.Durumu = false;
                btnDurum.Text = "Pasif Yap";
                gridIndirim.SetFocusedRowCellValue(colDurumu, false);
                btnDurum.ImageOptions.ImageIndex = 16;
                indirimDal.Save(context);
            }
            else
            {
                secilen.Durumu = true;
                btnDurum.Text = "Aktif Yap";
                gridIndirim.SetFocusedRowCellValue(colDurumu, true);
                btnDurum.ImageOptions.ImageIndex = 15;
                indirimDal.Save(context);
            }
           
        }

        private void gridIndirim_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (Convert.ToBoolean(gridIndirim.GetFocusedRowCellValue(colDurumu)))
            {
                btnDurum.Text = "Pasif Yap";
                btnDurum.ImageOptions.ImageIndex = 16;
            }
            else
            {
                btnDurum.Text = "Aktif Yap";
                btnDurum.ImageOptions.ImageIndex = 15;
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            gridIndirim.OptionsView.ShowAutoFilterRow = true ? gridIndirim.OptionsView.ShowAutoFilterRow == false : gridIndirim.OptionsView.ShowAutoFilterRow = true;
        }
    }
}
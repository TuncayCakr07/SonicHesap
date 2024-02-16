using DevExpress.XtraEditors;
using SonicHesap.BackOffice.Stok;
using SonicHesap.Entities.Context;
using SonicHesap.Entities.Data_Access;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SonicHesap.BackOffice.Fiyat_Degistir
{
    public partial class FrmTopluFiyat : DevExpress.XtraEditors.XtraForm
    {
        SonicHesapContext context=new SonicHesapContext();
        StokDAL stokDal=new StokDAL();
        public FrmTopluFiyat()
        {
            InitializeComponent();
            Listele();
        }

        private void Listele()
        {
            gridControl1.DataSource = context.Stoklar.Local.ToBindingList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmStokSec form=new FrmStokSec(true);
            form.ShowDialog();
            if (form.secildi)
            {
                foreach (var itemStok in form.secilen)
                {
                    stokDal.AddOrUpdate(context, itemStok);
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Değişiklikleri kontrol etmek için bir değişken tanımlayın
            bool degisiklikVarMi = context.ChangeTracker.HasChanges();

            // Eğer değişiklik varsa kullanıcıya sor
            if (degisiklikVarMi)
            {
                DialogResult result = MessageBox.Show("Değişiklikleri kaydetmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                // Kullanıcının seçimine göre işlem yap
                if (result == DialogResult.Yes)
                {
                    // Değişiklikleri kaydet
                    stokDal.Save(context);
                }
                else
                {
                    // Forma geri dön
                    return;
                }
            }
            else
            {
                // Değişiklik yoksa kullanıcıya bildir
                MessageBox.Show("Kaydedilecek bir değişiklik bulunmuyor.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            var message = MessageBox.Show("Seçili ürünü listeden çıkarmak istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (message == DialogResult.Yes)
            {
                var secilen = gridView1.GetFocusedRowCellValue(colStokKodu).ToString();
                var result = stokDal.GetByFilter(context, c => c.StokKodu == secilen);
                context.Entry(result).State = EntityState.Detached;
            }
            else
            {
                return;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (gridView1.OptionsView.ShowAutoFilterRow)
            {
                // Eğer otomatik filtre satırı görünürse, gizle
                gridView1.OptionsView.ShowAutoFilterRow = false;
            }
            else
            {
                // Eğer otomatik filtre satırı görünmüyorsa, görünür yap
                gridView1.OptionsView.ShowAutoFilterRow = true;
            }
        }


        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
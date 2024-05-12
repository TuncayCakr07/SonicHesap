using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using SonicHesap.Entities.Context;
using SonicHesap.Entities.Data_Access;
using SonicHesap.Entities.Tables;
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

namespace SonicHesap.BackOffice.Kod
{
    public partial class FrmKodlar : DevExpress.XtraEditors.XtraForm
    {
        SonicHesapContext context=new SonicHesapContext();
        KodDAL KodDAL = new KodDAL();
        private Entities.Tables.Kod _entity;
        private string _tablo;
        public FrmKodlar(string tablo)
        {
            InitializeComponent();
            _tablo = tablo;
            context.Kodlar.Where(c=>c.Tablo==tablo).Load();
            gridContTanim.DataSource = context.Kodlar.Local.ToBindingList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
            MessageBox.Show("Kod Sisteme Kaydedildi!","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridTanim_ShowingEditor(object sender, CancelEventArgs e)
        {
            if (gridTanim.FocusedRowHandle!=GridControl.NewItemRowHandle)
            {
                e.Cancel = true;
            }
        }

        private void gridTanim_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            Entities.Tables.Kod row = (Entities.Tables.Kod)e.Row;
            if (context.Kodlar.Local.Any(c=>c.OnEki==row.OnEki))
            {
                MessageBox.Show("Aynı Ön Ek Daha önce Kullanılmıştır.Kaydedilemez!","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Error);
                gridTanim.CancelUpdateCurrentRow();
            }
        }

        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if(MessageBox.Show("Seçili Kaydı Silmek İstediğinize Emin Misiniz?", "Uyarı!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                gridTanim.DeleteSelectedRows();
            }
        }
    }
}
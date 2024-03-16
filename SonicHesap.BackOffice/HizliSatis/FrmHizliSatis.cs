using DevExpress.XtraEditors;
using SonicHesap.BackOffice.Stok;
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

namespace SonicHesap.BackOffice.HizliSatis
{
    public partial class FrmHizliSatis : DevExpress.XtraEditors.XtraForm
    {
        SonicHesapContext context = new SonicHesapContext();
        HizliSatisGrupDAL hizliSatisGrupDal = new HizliSatisGrupDAL();
        HizliSatisDAL hizliSatisDal = new HizliSatisDAL();
        public FrmHizliSatis()
        {
            InitializeComponent();
            context.HizliSatisGruplari.Load();
            context.HizliSatislar.Load();
            gridContGrupEkle.DataSource = context.HizliSatisGruplari.Local.ToBindingList();
            gridContUrunEkle.DataSource = context.HizliSatislar.Local.ToBindingList();
        }

        private void FrmHizliSatis_Load(object sender, EventArgs e)
        {

        }

        private void KayitAc()
        {
            grpBilgi.Enabled = true;
            txtGrupAdi.Enabled = true;
            txtAciklama.Enabled = true;
            btnYeni.Enabled = false;
            btnSil.Enabled = false;
            btnKaydet.Enabled = true;
            btnVazgec.Enabled = true;
            gridContUrunEkle.Enabled = false;
            btnUrunEkle.Enabled = false;
            btnUrunSil.Enabled = false;
        }

        private void KayitKapat()
        {
            grpBilgi.Enabled = false;
            btnYeni.Enabled = true;
            btnSil.Enabled = true;
            btnKaydet.Enabled = false;
            btnVazgec.Enabled = false;
            gridContUrunEkle.Enabled = true;
            btnUrunEkle.Enabled = true;
            btnUrunSil.Enabled = true;
        }

        private void gridGrupEkle_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            gridUrunEkle.ActiveFilterString = $"GrupId='{gridGrupEkle.GetFocusedRowCellValue(colId)}'";
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            KayitAc();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            KayitKapat();
            hizliSatisGrupDal.AddOrUpdate(context, new Entities.Tables.HizliSatisGrup
            {
                GrupAdi = txtGrupAdi.Text,
                Aciklama = txtAciklama.Text,
            });
            hizliSatisGrupDal.Save(context);
            MessageBox.Show("Ürün Grubu Kaydedilmiştir!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtAciklama.Text = null;
            txtGrupAdi.Text = null;
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            KayitKapat();
            txtAciklama.Text = null;
            txtGrupAdi.Text = null;
        }

        private void btnFormKapat_Click(object sender, EventArgs e)
        {
            txtAciklama.Text = null;
            txtGrupAdi.Text = null;
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int grupId = (int)gridGrupEkle.GetFocusedRowCellValue(colId);
            DialogResult result = MessageBox.Show("Seçili Ürün Grubu ve Bu Gruba Ait Ürünler Silinecektir. Emin Misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                hizliSatisDal.Delete(context, c => c.GrupId == grupId);
                gridGrupEkle.DeleteSelectedRows();
                hizliSatisDal.Save(context);
                MessageBox.Show("Silme İşlemi Tamamlandı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                return;
            }
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            FrmStokSec form = new FrmStokSec(true);
            form.ShowDialog();
            if (form.secildi)
            {
                foreach (var itemStok in form.secilen)
                {
                    if (context.HizliSatislar.Count(c => c.Barkod == itemStok.Barkod) != 0)
                    {
                        hizliSatisDal.AddOrUpdate(context, new Entities.Tables.HizliSatis
                        {
                            Barkod = itemStok.Barkod,
                            UrunAdi = itemStok.StokAdi,
                            GrupId = (int)gridGrupEkle.GetFocusedRowCellValue(colId)
                        });
                    }
                    else
                    {
                        hizliSatisDal.AddOrUpdate(context, new Entities.Tables.HizliSatis
                        {
                            Barkod = itemStok.Barkod,
                            UrunAdi = itemStok.StokAdi,
                            GrupId = (int)gridGrupEkle.GetFocusedRowCellValue(colId)
                        });
                    }
                }
                hizliSatisDal.Save(context);
                MessageBox.Show("Ürünler Hızlı Satış Gruplarına Eklenmiştir.!","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }


        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seçili Gruptaki Ürün Listeden Çıkarılacaktır. Emin Misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                gridUrunEkle.DeleteSelectedRows();
                hizliSatisDal.Save(context);
                MessageBox.Show("Seçili Ürün Gruptan Çıkarıldı!","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                return;
            }
        }
    }
}
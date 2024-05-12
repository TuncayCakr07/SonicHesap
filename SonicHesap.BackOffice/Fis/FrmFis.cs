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
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SonicHesap.BackOffice.Fis
{

    public partial class FrmFis : DevExpress.XtraEditors.XtraForm
    {
        SonicHesapContext context = new SonicHesapContext();
        FisDAL fisDal = new FisDAL();
        KasaHareketDAL kasaHareketDal = new KasaHareketDAL();
        StokHareketDAL stokHareketDal = new StokHareketDAL();
        public FrmFis()
        {
            InitializeComponent();
        }

        private void FrmFis_Load(object sender, EventArgs e)
        {
            Listele();
        }
        void Listele()
        {
            context = new SonicHesapContext();
            gridContFis.DataSource = fisDal.GetAll(context);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Both;
        }

        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            filterControl1.ApplyFilter();
        }

        private void btnFiltreKapat_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2;
        }

        private void btnFormKapat_Click(object sender, EventArgs e)
        {
            filterControl1.FilterString = null;
            filterControl1.ApplyFilter();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Entities.Tables.Fis secilen = (Entities.Tables.Fis)gridFis.GetFocusedRow();
            if (!String.IsNullOrEmpty(secilen.FisBaglantiKodu))
            {
                if (MessageBox.Show($"Bu Fiş İle Bağlantılı Olan {secilen.FisBaglantiKodu} Kodlu Ödeme Fişi Birlikte Silinecektir. Emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    fisDal.Delete(context, c => c.FisKodu == secilen.FisBaglantiKodu);
                    fisDal.Delete(context, c => c.FisKodu == secilen.FisKodu);
                    kasaHareketDal.Delete(context, c => c.FisKodu == secilen.FisKodu);
                    stokHareketDal.Delete(context, c => c.FisKodu == secilen.FisKodu);
                    fisDal.Save(context);
                    MessageBox.Show("Seçili Olan Veri Silindi!", "Bilgi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Listele();
                }
            }
            else
            {
                //string secilen = gridFis.GetFocusedRowCellValue(colFisKodu)?.ToString();
                if (MessageBox.Show("Seçili Olan Veriyi Silmek İstediğinize Eminmisiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    fisDal.Delete(context, c => c.FisKodu == secilen.FisKodu);
                    kasaHareketDal.Delete(context, c => c.FisKodu == secilen.FisKodu);
                    stokHareketDal.Delete(context, c => c.FisKodu == secilen.FisKodu);
                    fisDal.Save(context);
                    MessageBox.Show("Seçili Olan Veri Silindi!", "Bilgi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Listele();
                }

                else
                {
                    MessageBox.Show("Silmek İçin Bir Fiş Seçiniz.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FisIslem_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmFisIslem form = new FrmFisIslem(null, e.Item.Caption);
            form.ShowDialog();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {

            if (gridFis.GetFocusedRow() != null)
            {
                Entities.Tables.Fis secilen = (Entities.Tables.Fis)gridFis.GetFocusedRow();
                if (secilen.FisTuru == "Fiş Ödemesi")
                {
                    FrmFisIslem form = new FrmFisIslem(secilen.FisBaglantiKodu, null);
                    form.ShowDialog();
                    Listele();
                }
                else
                {
                    FrmFisIslem form = new FrmFisIslem(secilen.FisKodu, null);
                    form.ShowDialog();
                    Listele();
                }

            }
            else
            {
                MessageBox.Show("Düzenlemek için bir fiş seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Entities.Tables.Fis secilen = (Entities.Tables.Fis)gridFis.GetFocusedRow();
            if (!secilen.FisTuru.Contains("Sipariş Fişi"))
            {
                MessageBox.Show("Faturalandırmak İstediğiniz Fiş Bir Sipariş Fişi Değil!","Uyarı!");
            }
            else
            {
                FrmFisIslem form = new FrmFisIslem(secilen.FisKodu, null,siparisFaturalandir:true);
                form.ShowDialog();
            }
        }
    }
}
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SonicHesap.BackOffice.Fis
{
    public partial class FrmSeriNoGir : DevExpress.XtraEditors.XtraForm
    {
        public string veriSeriNo;
        public FrmSeriNoGir(string veri)
        {
            InitializeComponent();
            if (veri != null)
            {
                string[] veriListesi = veri.Split(new[] { System.Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var item in veriListesi)
                {
                    listSeriNo.Items.Add(item);
                }
            }

        }
        void KayitAc()
        {
            BtnYeni.Enabled = false;
            btnSil.Enabled = false;
            btnKaydet.Enabled = true;
            btnVazgeç.Enabled = true;
            grpBilgi.Enabled = true;
            txtSeriNo.Focus();  
        }
        void kayitKapat()
        {
            BtnYeni.Enabled = true;
            btnSil.Enabled = true;
            btnKaydet.Enabled = false;
            btnVazgeç.Enabled = false;
            grpBilgi.Enabled = false;
            txtSeriNo.Text = null;
        }

        private void FrmSeriNoGir_Load(object sender, EventArgs e)
        {

        }

        private void BtnYeni_Click(object sender, EventArgs e)
        {
            KayitAc();
            txtSeriNo.Focus();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (listSeriNo.SelectedItem != null)
            {
                DialogResult result = MessageBox.Show("Silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    listSeriNo.Items.Remove(listSeriNo.SelectedItem);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir öğe seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            listSeriNo.Items.Add(txtSeriNo.Text);
            kayitKapat();
            MessageBox.Show("Veri Listeye Kaydedildi!","Bilgi!",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnVazgeç_Click(object sender, EventArgs e)
        {
            kayitKapat();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSeriNoGir_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (listSeriNo.Items.Count!=0)
            {
                foreach (var item in listSeriNo.Items)
                {
                    veriSeriNo += item + System.Environment.NewLine;
                }
            }
        }
    }
}
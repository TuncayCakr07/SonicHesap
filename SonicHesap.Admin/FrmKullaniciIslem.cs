using DevExpress.XtraEditors;
using SonicHesap.Entities.Context;
using SonicHesap.Entities.Data_Access;
using SonicHesap.Entities.Interfaces;
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
    public partial class FrmKullaniciIslem : DevExpress.XtraEditors.XtraForm
    {
        SonicHesapContext context = new SonicHesapContext();
        KullaniciDAL kullaniciDal = new KullaniciDAL();
        Kullanici _entity;
        public bool saved=false;
        private string parola, cevap;   
        public FrmKullaniciIslem(Kullanici entity)
        {
            InitializeComponent();
            treeList1.ExpandAll();
            if (entity!=null)
            {
                parola = entity.Parola;
                cevap = entity.Cevap;
                entity.Parola = null;
                entity.Cevap = null;
            }
            _entity = entity;
            txtKullaniciAdi.DataBindings.Add("Text", _entity, "KullaniciAdi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAdi.DataBindings.Add("Text", _entity, "Adi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtSoyadi.DataBindings.Add("Text", _entity, "Soyadi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtParola.DataBindings.Add("Text", _entity, "Parola", false, DataSourceUpdateMode.OnPropertyChanged);
            txtGorevi.DataBindings.Add("Text", _entity, "Gorevi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtHatirlatma.DataBindings.Add("Text", _entity, "HatirlatmaSorusu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtCevap.DataBindings.Add("Text", _entity, "Cevap", false, DataSourceUpdateMode.OnPropertyChanged);
            AyarYukle();
        }

        private void AyarYukle()
        {
            if (!string.IsNullOrEmpty(_entity.KullaniciAdi))
            {
                foreach (var item in context.KullaniciRolleri.Where(c=>c.KullaniciAdi== _entity.KullaniciAdi).ToList())
                {
                    treeList1.SetNodeCheckState(treeList1.Nodes[item.RootId].Nodes[item.ParentId], item.Yetki == true ? CheckState.Checked : CheckState.Unchecked, true);
                }
            }
        }

        private void Kaydet()
        {
            for (int i = 0; i < treeList1.Nodes.Count; i++)
            {
                for (int j = 0; j < treeList1.Nodes[i].Nodes.Count; j++)
                {
                    if (context.KullaniciRolleri.Count(c=>c.KullaniciAdi==txtKullaniciAdi.Text && c.RootId==i && c.ParentId==j)==0)
                    {
                        context.KullaniciRolleri.Add(new KullaniciRol
                        {
                            KullaniciAdi = txtKullaniciAdi.Text,
                            FormAdi = treeList1.Nodes[i].GetDisplayText(treeListColumn2),
                            KontrolAdi= treeList1.Nodes[i].Nodes[j].GetDisplayText(treeListColumn2),
                            RootId = i,
                            ParentId = j,
                            Yetki = treeList1.Nodes[i].Nodes[j].Checked
                        });
                    }
                    else
                    {
                        context.KullaniciRolleri.SingleOrDefault(c => c.KullaniciAdi == txtKullaniciAdi.Text && c.RootId == i && c.ParentId == j).Yetki = treeList1.Nodes[i].Nodes[j].Checked;
                    }
                }
            }
            context.SaveChanges();
        }

        private void FrmKullaniciIslem_Load(object sender, EventArgs e)
        {

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(_entity.Parola))
            {
                txtParola.Text = parola;
                txtParolaTekrar.Text = parola;
            }
            if (String.IsNullOrEmpty(_entity.Cevap))
            {
                txtCevap.Text = cevap;
            }
            if (txtParola.Text!=txtParolaTekrar.Text)
            {
                MessageBox.Show("Parola alanları Uyuşmamaktadır.Lütfen Kontrol Ediniz!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                
                if (_entity.KayitTarihi==null)
                {
                    _entity.KayitTarihi = DateTime.Now;
                }
                if (kullaniciDal.AddOrUpdate(context, _entity))
                {
                    Kaydet();
                    saved = true;
                    MessageBox.Show("Kullanıcı Sisteme Kaydedildi", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }
    }
}
﻿using DevExpress.XtraEditors;
using SonicHesap.BackOffice.Tanimlar;
using SonicHesap.Entities.Context;
using SonicHesap.Entities.Data_Access;
using SonicHesap.Entities.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SonicHesap.BackOffice.Personel
{
    public partial class FrmPersonelIslem : DevExpress.XtraEditors.XtraForm
    {
        Entities.Tables.Personel _entity;
        PersonelDAL personelDal=new PersonelDAL();
        SonicHesapContext context=new SonicHesapContext();
        public bool saved=false;
        public FrmPersonelIslem(Entities.Tables.Personel entity)
        {
            InitializeComponent();
            _entity = entity;
            toggleCalisiyor.DataBindings.Add("EditValue",_entity,"Calisiyor",false,DataSourceUpdateMode.OnPropertyChanged);
            txtPersonelKodu.DataBindings.Add("Text",_entity,"PersonelKodu",false,DataSourceUpdateMode.OnPropertyChanged);
            txtPersonelAdi.DataBindings.Add("Text",_entity,"PersonelAdi",false,DataSourceUpdateMode.OnPropertyChanged);
            btnUnvani.DataBindings.Add("Text",_entity,"Unvani",false,DataSourceUpdateMode.OnPropertyChanged);
            txtTcKimlikNo.DataBindings.Add("Text",_entity,"TcKimlikNo",false,DataSourceUpdateMode.OnPropertyChanged);
            cmbIseGirisTarihi.DataBindings.Add("EditValue", _entity, "IseGirisTarihi", true, DataSourceUpdateMode.OnPropertyChanged,null, "F");
            cmbIstenCikisTarihi.DataBindings.Add("EditValue", _entity, "IstenCikisTarihi", true, DataSourceUpdateMode.OnPropertyChanged, null, "F");
            txtVergiDairesi.DataBindings.Add("Text", _entity, "VergiDairesi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtVergiNo.DataBindings.Add("Text", _entity, "VergiNo", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAciklama.DataBindings.Add("Text", _entity, "Aciklama", false, DataSourceUpdateMode.OnPropertyChanged);
            txtCepTelefonu.DataBindings.Add("Text", _entity, "CepTelefonu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtTelefon.DataBindings.Add("Text", _entity, "Telefon", false, DataSourceUpdateMode.OnPropertyChanged);
            txtFax.DataBindings.Add("Text", _entity, "Fax", false, DataSourceUpdateMode.OnPropertyChanged);
            txtEmail.DataBindings.Add("Text", _entity, "Email", false, DataSourceUpdateMode.OnPropertyChanged);
            txtWeb.DataBindings.Add("Text", _entity, "Web", false, DataSourceUpdateMode.OnPropertyChanged);
            txtIl.DataBindings.Add("Text", _entity, "Il", false, DataSourceUpdateMode.OnPropertyChanged);
            txtIlce.DataBindings.Add("Text", _entity, "Ilce", false, DataSourceUpdateMode.OnPropertyChanged);
            txtSemt.DataBindings.Add("Text", _entity, "Semt", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAdres.DataBindings.Add("Text", _entity, "Adres", false, DataSourceUpdateMode.OnPropertyChanged);
            calcAylikMaasi.DataBindings.Add("Value",_entity, "AylikMaasi",true,DataSourceUpdateMode.OnPropertyChanged,0,"C2");
            calcPrimOrani.DataBindings.Add("Value",_entity, "PrimOrani", true,DataSourceUpdateMode.OnPropertyChanged,0,"'%'0");
        }

        private void FrmPersonelIslem_Load(object sender, EventArgs e)
        {

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Personeli kaydetmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (personelDal.AddOrUpdate(context, _entity))
                    {
                        SettingsTool.AyarDegistir(SettingsTool.Ayarlar.KullaniciAyarlari_KullanıcıAdı, txtPersonelAdi.Text);
                        SettingsTool.AyarDegistir(SettingsTool.Ayarlar.KullaniciAyarlari_Parola, txtPersonelKodu.Text);
                        personelDal.Save(context);
                        MessageBox.Show("Personel Kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        saved = true;
                        this.Close();
                    }
                }
                else if (result == DialogResult.No)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnUnvani_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FrmTanim form = new FrmTanim(FrmTanim.TanimTuru.PersonelUnvan);
            form.ShowDialog();
            if (form.secildi)
            {
                btnUnvani.Text = form._entity.Tanimi;
            }
        }
    }
}
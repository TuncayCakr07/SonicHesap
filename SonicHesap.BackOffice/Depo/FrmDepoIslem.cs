﻿using DevExpress.XtraEditors;
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

namespace SonicHesap.BackOffice.Depo
{
    public partial class FrmDepoIslem : DevExpress.XtraEditors.XtraForm
    {
        private Entities.Tables.Depo _entity;
        private DepoDAL depoDal=new DepoDAL();
        private SonicHesapContext context=new SonicHesapContext();
        public bool kaydedildi=false;
        public FrmDepoIslem(Entities.Tables.Depo entity)
        {
            InitializeComponent();
            _entity = entity;
            txtDepoKodu.DataBindings.Add("Text", _entity, "DepoKodu");
            txtDepoAdi.DataBindings.Add("Text", _entity, "DepoAdi");
            txtYetkiliKodu.DataBindings.Add("Text", _entity, "YetkiliKodu");
            txtYetkiliAdi.DataBindings.Add("Text", _entity, "YetkiliAdi");
            txtTelefon.DataBindings.Add("Text", _entity, "Telefon");
            txtIl.DataBindings.Add("Text", _entity, "Il");
            txtIlce.DataBindings.Add("Text", _entity, "Ilce");
            txtSemt.DataBindings.Add("Text", _entity, "Semt");
            txtAdres.DataBindings.Add("Text", _entity, "Adres");
            txtAciklama.DataBindings.Add("Text", _entity, "Aciklama");
        }

        private void FrmDepoIslem_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (depoDal.AddOrUpdate(context,_entity))
            {
                depoDal.Save(context);
                MessageBox.Show("Depo Kaydedildi!","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
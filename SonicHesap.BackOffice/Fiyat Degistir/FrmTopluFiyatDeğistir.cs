using DevExpress.XtraEditors;
using SonicHesap.Entities.Tables.OtherTables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SonicHesap.BackOffice.Fiyat_Degistir
{
    public partial class FrmTopluFiyatDeğistir : DevExpress.XtraEditors.XtraForm
    {
        public List<FiyatDegistir> List;
        public bool secildi = false;
        public FrmTopluFiyatDeğistir()
        {
            InitializeComponent();
            List=new List<FiyatDegistir> 
            {
                new FiyatDegistir
                {
                    FiyatTuru="Alış Fiyatı-1",
                    KolonAdi="AlisFiyati1",
                    Degistir=false,
                    DegisimTuru="Yüzde",
                    DegisimYonu="Arttır",
                    Degeri=0
                },
                  new FiyatDegistir
                {
                    FiyatTuru="Alış Fiyatı-2",
                    KolonAdi="AlisFiyati2",
                    Degistir=false,
                    DegisimTuru="Yüzde",
                    DegisimYonu="Arttır",
                    Degeri=0
                },
                  new FiyatDegistir
                {
                    FiyatTuru="Alış Fiyatı-3",
                    KolonAdi="AlisFiyati3",
                    Degistir=false,
                    DegisimTuru="Yüzde",
                    DegisimYonu="Arttır",
                    Degeri=0
                },
                    new FiyatDegistir
                {
                    FiyatTuru="Satış Fiyatı-1",
                    KolonAdi="SatisFiyati1",
                    Degistir=false,
                    DegisimTuru="Yüzde",
                    DegisimYonu="Arttır",
                    Degeri=0
                },
                          new FiyatDegistir
                {
                    FiyatTuru="Satış Fiyatı-2",
                    KolonAdi="SatisFiyati2",
                    Degistir=false,
                    DegisimTuru="Yüzde",
                    DegisimYonu="Arttır",
                    Degeri=0
                },
                 new FiyatDegistir
                {
                    FiyatTuru="Satış Fiyatı-3",
                    KolonAdi="SatisFiyati3",
                    Degistir=false,
                    DegisimTuru="Yüzde",
                    DegisimYonu="Arttır",
                    Degeri=0
                }
            };
            gridControl1.DataSource = List;
        }

        private void FrmTopluFiyatDeğistir_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            secildi = true;
            this.Close();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
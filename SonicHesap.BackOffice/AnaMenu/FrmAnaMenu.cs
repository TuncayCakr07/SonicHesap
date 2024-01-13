using SonicHesap.BackOffice.Cari;
using SonicHesap.BackOffice.Stok;
using SonicHesap.Entities.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SonicHesap.BackOffice
{
    public partial class FrmAnaMenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmAnaMenu()
        {
            InitializeComponent();
            using (var context=new SonicHesapContext())
            {
                context.Database.CreateIfNotExists();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmStok form=new FrmStok();
            form.MdiParent = this;
            form.Show();
        }

        private void btnCari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmCari form = new FrmCari();
            form.MdiParent = this;
            form.Show();
        }
    }
}

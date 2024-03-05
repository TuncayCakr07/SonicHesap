using DevExpress.XtraEditors;
using SonicHesap.Entities.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SonicHesap.BackOffice.Ajanda
{
    public partial class FrmAjanda : DevExpress.XtraEditors.XtraForm
    {
        SonicHesapContext context = new SonicHesapContext();
        public FrmAjanda()
        {
            InitializeComponent();
       
            context.EFAppointments.Load();
            context.EFResources.Load();

            schedulerControl1.DataStorage.Appointments.DataSource= context.EFAppointments.Local.ToBindingList();
            schedulerControl1.DataStorage.Resources.DataSource = context.EFResources.Local.ToBindingList();
        }

        private void FrmAjanda_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Değişiklikleri kaydetmek istiyor musunuz?", "Onay", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                context.SaveChanges();
                MessageBox.Show("Etkinlik Ajandaya Kaydedildi!","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

    }
}
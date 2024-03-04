using DevExpress.XtraEditors;
using SonicHesap.Entities.Context;
using SonicHesap.Entities.Data_Access;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SonicHesap.BackOffice.Raporlar
{
    public partial class FrmOzgunRaporHazirla : DevExpress.XtraEditors.XtraForm
    {
        List<object> veriListesi = new List<object>();
        SonicHesapContext context = new SonicHesapContext();
        public FrmOzgunRaporHazirla()
        {
            InitializeComponent();
        }

        private void btnHazirla_Click(object sender, EventArgs e)
        {
            foreach (var itemChecked in checkedListBoxControl1.Items.Where(c=>c.CheckState==CheckState.Checked).ToList())
            {
                Type tip = Assembly.Load("SonicHesap.Entities").GetTypes().SingleOrDefault(c => c.Name == itemChecked.Value.ToString());
                object veri=Activator.CreateInstance(tip);

                MethodInfo info=tip.GetMethod(itemChecked.Tag.ToString());
                try
                {
                    veriListesi.Add(info.Invoke(veri, new object[] { context }));
                }
                catch (Exception exception)
                {
                    veriListesi.Add(info.Invoke(veri, new object[] { context,null}));
                }
            }
            FrmOzgunRaporlar form = new FrmOzgunRaporlar(veriListesi);
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }
    }
}
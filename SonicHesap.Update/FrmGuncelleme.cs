using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SonicHesap.Update
{
    public partial class FrmGuncelleme : DevExpress.XtraEditors.XtraForm
    {
        public static bool IsRunning(string ProgramAdi)
        {
            return Process.GetProcessesByName(ProgramAdi).Length > 0;
        }
        public FrmGuncelleme()
        {
            InitializeComponent();
            if (IsRunning("SonicHesap.BackOffice"))
            {
                if (MessageBox.Show("Güncelleme İşleminden Önce Açık Olan Uygulamalarınızın Kapatılması Gerekiyor. Kapatma İşlemini Onaylıyormusunuz?","Uyarı!",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
                {
                    foreach (var process in Process.GetProcessesByName("SonicHesap.BackOffice"))
                    {
                        process.CloseMainWindow();
                        process.Kill();
                    }
                }
            }
        }
    }
}

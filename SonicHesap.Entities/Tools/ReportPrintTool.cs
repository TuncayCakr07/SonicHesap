using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonicHesap.Entities.Tools
{
    public class ReportsPrintTool
    {
        public void RaporYazdir(XtraReport rapor)
        {
            ReportPrintTool raporYazdir =new ReportPrintTool(rapor);
            switch (SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_FaturaYazdirmaAyari))
            {
                case "0":
                    raporYazdir.Print();
                    break;
                case "1":
                    raporYazdir.PrintDialog();
                    break;
                case "2":
                    raporYazdir.ShowPreviewDialog();
                    break;
            }
           
        }
    }
}

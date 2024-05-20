using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonicHesap.Entities.Tools.LoadingTool
{
    public class LoadingTool
    {
       public SplashScreenManager manager;
        public LoadingTool(XtraForm form)
        {
            manager = new SplashScreenManager(form,typeof(FrmLoading),true,true);
        }

        public void AnimasyonBaslat()
        {
            manager.ShowWaitForm();
        }

        public void AnimasyonBitir()
        {
            manager.CloseWaitForm();
        }
    }
}

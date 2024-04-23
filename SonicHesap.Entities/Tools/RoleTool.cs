using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using SonicHesap.Entities.Context;
using SonicHesap.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonicHesap.Entities.Tools
{
    public static class RoleTool
    {
        public static Kullanici KullaniciEntity;
        public static void RooleriYukle(XtraForm form)
        {
            SonicHesapContext context = new SonicHesapContext();
            foreach (var item in context.KullaniciRolleri.Where(c=>c.KullaniciAdi==KullaniciEntity.KullaniciAdi && c.FormAdi==form.Name && c.Yetki==false).ToList())
            {
                var bulunan = form.Controls.Find(item.KontrolAdi, true).SingleOrDefault();
                if (bulunan != null)
                {
                    bulunan.Enabled = false;
                }
            }
        }
        public static void RooleriYukle(RibbonControl form)
        {
            SonicHesapContext context = new SonicHesapContext();
            foreach (var item in context.KullaniciRolleri.Where(c => c.KullaniciAdi == KullaniciEntity.KullaniciAdi && c.FormAdi =="FrmAnaMenu" && c.Yetki == false).ToList())
            {
              form.Items.SingleOrDefault(c => c.Name == item.KontrolAdi).Enabled = false;
            }
        }
    }
}

using SonicHesap.Entities.Context;
using SonicHesap.Entities.Data_Access;
using SonicHesap.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace SonicHesap.Entities.Tools
{
    public static class ConverterTool
    {
        private static StokHareket StokToStokHareket(SonicHesapContext contex,Entities.Tables.Stok entity,decimal miktar)
        {
            StokHareket stokHareket = new StokHareket();
            IndirimDAL indirimDal = new IndirimDAL();
            stokHareket.StokId = entity.Id;
            stokHareket.IndirimOrani = indirimDal.StokIndirimi(contex, entity.StokKodu);
            stokHareket.DepoId = Convert.ToInt32(SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_VarsayilanDepo));
            //stokHareket.BirimFiyati = txtFisTuru.Text == "Alış Faturası" ? entity.AlisFiyati1 : entity.SatisFiyati1;
            stokHareket.Miktar = miktar;
            stokHareket.Kdv = entity.SatisKdv;
            stokHareket.Tarih = DateTime.Now;
            return stokHareket;
        }

        public static decimal StringToDecimal(string ifade,string ondalikAyrac)
        {
            string ondalikKarakter=System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator.ToString();
            return Convert.ToDecimal(ifade.Replace(ondalikAyrac, ondalikKarakter));
        }
    }
}

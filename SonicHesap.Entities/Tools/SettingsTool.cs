    using IniParser;
using IniParser.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SonicHesap.Entities.Tools
{
    public static class SettingsTool
    {
        private static FileIniDataParser parser = new FileIniDataParser();
        private static IniData data;
        private static string dosyaAdi = "Settings.ini";

        static SettingsTool()
        {
            // Dosya yoksa oluştur
            if (!System.IO.File.Exists(Application.StartupPath + "\\" + dosyaAdi))
            {
                data = new IniData();
                // İlk ayarları burada varsayılan olarak belirleyebilirsiniz
                data["KullaniciAyarlari"]["KullaniciAdi"] = "default_user";
                data["KullaniciAyarlari"]["Parola"] = "default_password";
                data["SatisAyarlari"]["VarsayilanDepo"] = "default_depo";
                data["YedeklemeAyarlari"]["YedeklemeKonumu"] = "default_yedekleme_konumu";
                parser.WriteFile(Application.StartupPath + "\\" + dosyaAdi, data);
            }
            else
            {
                data = parser.ReadFile(dosyaAdi);
            }
        }

        public enum Ayarlar
        {
            KullaniciAyarlari_KullanıcıAdı,
            KullaniciAyarlari_Parola,
            SatisAyarlari_VarsayilanDepo,
            SatisAyarlari_VarsayilanDepoAdi,
            SatisAyarlari_VarsayilanKasa,
            SatisAyarlari_VarsayilanKasaAdi,
            SatisAyarlari_FaturaYazdirmaAyari,
            SatisAyarlari_BilgiFisiYazdirmaAyari,
            SatisAyarlari_FaturaYazici,
            SatisAyarlari_BilgiFisiYazici,
            SatisAyarlari_FisKodu,
            YedeklemeAyarlari_YedeklemeKonumu,
            YedeklemeAyarlari_OtomatikYedekleme,
            YedeklemeAyarlari_OtomatikYedekAl,
            YedeklemeAyarlari_KaydedilmisTarih,
            GenelAyarlar_GuncellemeKontrol,
            DatabaseAyarlari_BaglantiCumlesi,
            FirmaAyarlari_FirmaAdi
        }

        public static void AyarDegistir(Ayarlar ayar, string value)
        {
            string[] gelenAyar = ayar.ToString().Split(Convert.ToChar("_"));
            if (data != null)
            {
                if (data.Sections.Count(c => c.SectionName == gelenAyar[0]) == 0)
                {
                    data.Sections.AddSection(gelenAyar[0]);
                    data[gelenAyar[0]].AddKey(gelenAyar[1]);
                }
                else
                {
                    data[gelenAyar[0]].AddKey(gelenAyar[1]);
                }
                data[gelenAyar[0]][gelenAyar[1]] = value;
            }
        }

        public static string AyarOku(Ayarlar ayar)
        {
            string[] gelenAyar = ayar.ToString().Split(Convert.ToChar("_"));
            return data[gelenAyar[0]][gelenAyar[1]];
        }

        public static void Save()
        {
            parser.WriteFile(dosyaAdi, data);
        }
    }
}

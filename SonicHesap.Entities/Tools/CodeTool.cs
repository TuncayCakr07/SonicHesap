using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonicHesap.Entities.Tools
{
    public static class CodeTool
    {
       public static string KodOlustur(string OnEki,string Kod)
        {
            int OnEkiUzunluk=OnEki.Length;
            int KodUzunluk=Kod.Length;  
            int KalanKarakter=12-(OnEkiUzunluk+KodUzunluk);
            string SifirDizisi = null;
            for (int i = 0; i < KalanKarakter; i++)
            {
                SifirDizisi +="0";
            }
            return OnEki+SifirDizisi+Kod;
        }
    }
}

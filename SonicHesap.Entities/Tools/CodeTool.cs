using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using SonicHesap.Entities.Context;
using System;
using System.Linq;


namespace SonicHesap.Entities.Tools
{
    
    public class CodeTool
    {
        SonicHesapContext context = new SonicHesapContext();
        //BarManager manager = new BarManager();
        //PopupMenu menu;
        //XtraForm _form;
        //private SonicHesapContext _context;
        //Table _table;

        //public enum Table
        //{
        //    Cari,
        //    Stok,
        //    Fis,
        //}

        //public CodeTool(XtraForm form, Table table, SonicHesapContext context)
        //{
        //    _form = form;
        //    _context = context;
        //    _table = table;
        //    manager.Form = _form;
        //    menu = new PopupMenu();
        //}

        //public void BarButonOlustur()
        //{
        //    foreach(var kod in _context.Kodlar.Where(c => c.Tablo == _table.ToString()).ToList())
        //    {
        //        BarButtonItem item = new BarButtonItem
        //        {
        //            Name = "btnKod" + kod.SonDeger,
        //            Tag = kod.Id,
        //            Caption = KodOlustur(kod.OnEki, kod.SonDeger),
        //        };
        //        item.ItemClick += Buton_Click;
        //        menu.AddItem(item);
        //    }
        //}

        //private void Buton_Click(object sender, ItemClickEventArgs e)
        //{
        //}

        //private string KodOlustur(string kodonEki, int kodsonDeger)
        //{
        //    int sifirSayisi = 12 - (kodonEki.Length + kodsonDeger.ToString().Length);
        //    string sifirDizisi = new string('0', sifirSayisi);
        //    return kodonEki + sifirDizisi + kodsonDeger;
        //}

        //public static string KodOlustur(string v1, string v2)
        //{
        //    throw new NotImplementedException();
        //}

        public static string KodOlustur(string OnEki, string Kod)
        {
            int OnEkiUzunluk = OnEki.Length;
            int KodUzunluk = Kod.Length;
            int KalanKarakter = 12 - (OnEkiUzunluk + KodUzunluk);
            string SifirDizisi = null;
            for (int i = 0; i < KalanKarakter; i++)
            {
                SifirDizisi += "0";
            }
            return OnEki + SifirDizisi + Kod;
        }
        public static string YeniFisOdemeKodu()
        {
            var context=new SonicHesapContext();
            var kod = context.Kodlar.SingleOrDefault(c => c.OnEki == "FO" && c.Tablo=="Fis");
            string oneki = kod.OnEki;
            string sonDeger = kod.SonDeger.ToString();
            int sifirSayisi=12-(oneki.Length+sonDeger.Length);
            string sifirDizisi = new string('0', sifirSayisi);
            kod.SonDeger++;
            context.SaveChanges();
            return oneki+sifirDizisi+sonDeger;
        }
    }
}

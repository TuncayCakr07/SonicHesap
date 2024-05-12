using SonicHesap.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonicHesap.Entities.Tables
{
    public class Fis : IEntity
    {
        public Fis Clone()
        {
            Fis yeniFis = new Fis();
            yeniFis.FisKodu=this.FisKodu;
            yeniFis.FisBaglantiKodu = this.FisBaglantiKodu;
            yeniFis.FisTuru=this.FisTuru;
            yeniFis.CariId=this.CariId;
            yeniFis.FaturaUnvani=this.FaturaUnvani;
            yeniFis.CepTelefonu=this.CepTelefonu;
            yeniFis.Il=this.Il;
            yeniFis.Ilce = Ilce;
            yeniFis.Semt = Semt;
            yeniFis.Adres = Adres;
            yeniFis.VergiDairesi=this.VergiDairesi;
            yeniFis.VergiNo=this.VergiNo;
            yeniFis.Tarih = Tarih;
            yeniFis.PlasiyerId = PlasiyerId;
            yeniFis.IskontoOrani = IskontoOrani;
            yeniFis.IskontoTutar = IskontoTutar;
            yeniFis.Alacak = Alacak;
            yeniFis.Borc = Borc;
            yeniFis.ToplamTutar = ToplamTutar;
            yeniFis.Aciklama = Aciklama;
            return yeniFis;
        }
        public int Id { get; set; }
        public string FisKodu { get; set; }
        public string FisBaglantiKodu { get; set; }
        public string FisTuru { get; set; }
        public Nullable<int> CariId { get; set; }
        public string FaturaUnvani { get; set; }
        public string CepTelefonu { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public string Semt { get; set; }
        public string Adres { get; set; }
        public string VergiDairesi { get; set; }
        public string VergiNo { get; set; }
        public string BelgeNo { get; set; }
        public DateTime Tarih { get; set; }
        public Nullable<int> PlasiyerId { get; set; }
        public decimal? IskontoOrani { get; set; }
        public decimal? IskontoTutar { get; set; }
        public decimal? Alacak { get; set; }
        public decimal? Borc { get; set; }
        public decimal? ToplamTutar { get; set; }
        public string Aciklama { get; set; }
        public virtual Cari Cari { get; set; }
        public virtual Personel Personel { get; set; }
    }
}

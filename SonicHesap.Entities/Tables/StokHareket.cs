using SonicHesap.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonicHesap.Entities.Tables
{
    public class StokHareket : IEntity
    {
        public int Id { get; set; }
        public string FisKodu { get; set; }
        public string Hareket { get; set; }
        public int StokId { get; set; }
        public Nullable<decimal> Miktar { get; set; }
        public int Kdv { get; set; }
        public Nullable<decimal> BirimFiyati { get; set; }
        public Nullable<decimal> IndirimOrani { get; set; }
        public int DepoId { get; set; }
        public string SeriNo { get; set; }
        public Nullable<DateTime> Tarih { get; set; }
        public string Aciklama { get; set; }
        public virtual Stok Stok { get; set; }
        public virtual Depo Depo { get; set; }
    }
}

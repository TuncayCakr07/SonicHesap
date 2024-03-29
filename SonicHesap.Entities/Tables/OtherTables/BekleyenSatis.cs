﻿using DevExpress.Drawing.Printing.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonicHesap.Entities.Tables.OtherTables
{
    public class BekleyenSatis
    {
        public int Id { get; set; }
        public string FisKodu { get; set; }
        public string FisTuru { get; set; }
        public string BelgeNo { get; set; }
        public string Aciklama { get; set; }
        public string CariKodu { get; set; }
        public string CariAdi { get; set; }
        public string PlasiyerKodu { get; set; }
        public string PlasiyerAdi { get; set; }
        public string FaturaUnvani { get; set; }
        public string VergiDairesi { get; set; }
        public string VergiNo { get; set; }
        public string CepTelefonu { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public string Semt { get; set; }
        public string Adres { get; set; }
        public decimal IskontoOrani { get; set; }
        public decimal OdenenTutar { get; set; }
        public List<StokHareket> StokHareketi { get; set; }
        public List<KasaHareket> KasaHareketi { get; set; }
    }
}
﻿using SonicHesap.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonicHesap.Entities.Tables
{
    public class HizliSatisGrup : IEntity
    {
        public int Id { get; set; }
        public string GrupAdi { get; set; }
        public string Aciklama { get; set; }
    }
}

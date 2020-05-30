using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KaVoo.Models
{
    public class Randevu
    {
        public int RandevuId { get; set; }
        public string RandevuTarihi { get; set; }
        public string RandevuSaati { get; set; }

        public string Telefon { get; set; }


    }
}
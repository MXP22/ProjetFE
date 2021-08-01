using System;
using System.Collections.Generic;

#nullable disable

namespace TheTipTopSiteweb.Models
{
    public partial class Coupon
    {
        public int Idcoupon { get; set; }
        public int? CodeCoupon { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? DatefFin { get; set; }
        public int? Iduser { get; set; }
        public int? Idlot { get; set; }
        public string Etat { get; set; }
    }
}

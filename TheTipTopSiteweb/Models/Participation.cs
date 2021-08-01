using System;
using System.Collections.Generic;

#nullable disable

namespace TheTipTopSiteweb.Models
{
    public partial class Participation
    {
        public Tuser User { get; set; }

        public int Numerocoupon { get; set; }

        public Lot Lot { get; set; }
    }
}

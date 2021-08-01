using System;
using System.Collections.Generic;

#nullable disable

namespace APITheTipTop.Models
{
    public partial class Tuser
    {
        public int Iduser { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime? Datenaissance { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public bool? ConfEmail { get; set; }
        public string Adresse { get; set; }
        public string CodePostal { get; set; }
        public string Ville { get; set; }
        public string Pays { get; set; }
        public string MotDepasse { get; set; }
        public int? Idrole { get; set; }
    }
}

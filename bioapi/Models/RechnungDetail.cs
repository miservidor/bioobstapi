using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace bioapi
{
    public partial class RechnungDetail
    {
        public int IdrechnungDetail { get; set; }
        public int? Idrechnung { get; set; }
        public string Rechnungnummer { get; set; }
        public int? Idartikel { get; set; }
        public string Bezeichnung { get; set; }
        public string Zusatz { get; set; }
        public double? Menge { get; set; }
        public string Einheit { get; set; }
        public double? Nettopreis { get; set; }
        public double? Steuer { get; set; }
    }
}

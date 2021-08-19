using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace bioapi
{
    public partial class Artikel
    {
        public int Idartikel { get; set; }
        public string Artikelnummer { get; set; }
        public int? Artikelgruppeid { get; set; }
        public string Bezeichnung { get; set; }
        public string Zusatz { get; set; }
        public string Mengeneinheit { get; set; }
        public double? Preis { get; set; }
        public int? Steuerid { get; set; }
        public string Artikelcol { get; set; }
        public string Beschreibung { get; set; }
        public string Image { get; set; }
    }
}

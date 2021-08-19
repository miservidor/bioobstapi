using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace bioapi
{
    public partial class Artikelgruppe
    {
        public uint Idartikelgruppe { get; set; }
        public string Artikelgruppecod { get; set; }
        public string Bezeichnung { get; set; }
        public int? Parentid { get; set; }
        public string Beschreibung { get; set; }
        public string Image { get; set; }
    }
}

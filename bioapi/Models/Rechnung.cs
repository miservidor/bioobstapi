using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace bioapi
{
    public partial class Rechnung
    {
        public int Idrechnung { get; set; }
        public string Rechnungnummer { get; set; }
        public DateTime? Datum { get; set; }
        public int? Idkunde { get; set; }
        public string Name { get; set; }
        public int? LieferAddressid { get; set; }
        public string Status { get; set; }
        public string Beschreibung { get; set; }
    }
}

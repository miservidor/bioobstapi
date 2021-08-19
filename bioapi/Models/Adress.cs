using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace bioapi
{
    public partial class Adress
    {
        public int Idadressen { get; set; }
        public int? Idkunde { get; set; }
        public string Type { get; set; }
        public string Straße { get; set; }
        public string Ort { get; set; }
        public string Plz { get; set; }
        public string Region { get; set; }
        public string Landiso { get; set; }
        public string Lat { get; set; }
        public string Lon { get; set; }
        public string KontaktEmail { get; set; }
    }
}

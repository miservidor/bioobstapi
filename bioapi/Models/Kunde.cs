using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace bioapi
{
    public partial class Kunde
    {
        public int Idkunde { get; set; }
        public string Nummer { get; set; }
        public int? Gruppekundeid { get; set; }
        public string Anrede { get; set; }
        public string Vorname { get; set; }
        public string Name { get; set; }
        public string Firma { get; set; }
        public string Telefon1 { get; set; }
        public string Telefon2 { get; set; }
        public string Email { get; set; }
        public string Detail { get; set; }
        public DateTime? Createdat { get; set; }
        public string Createdby { get; set; }
        public string Steuernummer { get; set; }
        public string Rabattgruppe { get; set; }
    }
}

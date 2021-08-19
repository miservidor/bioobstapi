using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace bioapi
{
    public partial class Steuer
    {
        public int Idsteuer { get; set; }
        public string Steuercode { get; set; }
        public string Steuerart { get; set; }
        public string Steuerbezeichnung { get; set; }
        public double? Steuerrunden { get; set; }
    }
}

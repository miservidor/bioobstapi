using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace bioapi
{
    public partial class Userlevelpermissions
    {
        public int Userlevelid { get; set; }
        public string Tablename { get; set; }
        public int Permission { get; set; }
    }
}

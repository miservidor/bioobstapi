using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace bioapi
{
    public partial class User
    {
        public int Iduser { get; set; }
        public string Email { get; set; }
        public string Pass { get; set; }
        public string Rol { get; set; }
        public string Vorname { get; set; }
        public string Name { get; set; }
        public string Telephone { get; set; }
        public DateTime? Created { get; set; }
        public string Confirmed { get; set; }
    }
}

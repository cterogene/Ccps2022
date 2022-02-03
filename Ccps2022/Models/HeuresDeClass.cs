using System;
using System.Collections.Generic;

namespace Ccps2022.Models
{
    public partial class HeuresDeClass
    {
        public int HeureID { get; set; }
        public string HeureDescription { get; set; } = null!;
        public string? Categorie { get; set; }
    }
}

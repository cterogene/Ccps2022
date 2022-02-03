using System;
using System.Collections.Generic;

namespace Ccps2022.Models
{
    public partial class Ministere
    {
        public int MinistereId { get; set; }
        public string MinistereNom { get; set; } = null!;
        public int IsActif { get; set; }
    }
}

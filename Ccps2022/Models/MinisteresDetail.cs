using System;
using System.Collections.Generic;

namespace Ccps2022.Models
{
    public partial class MinisteresDetail
    {
        public int MinistereDetailId { get; set; }
        public string NomMinistere { get; set; } = null!;
        public int MinistereId { get; set; }
    }
}

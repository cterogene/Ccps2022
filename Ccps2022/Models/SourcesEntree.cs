using System;
using System.Collections.Generic;

namespace Ccps2022.Models
{
    public partial class SourcesEntree
    {
        public int SourceId { get; set; }
        public string NomSource { get; set; } = null!;
        public string Monnaie { get; set; } = null!;
        public string? Description { get; set; }
    }
}

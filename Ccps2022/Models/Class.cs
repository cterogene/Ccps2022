using System;
using System.Collections.Generic;

namespace Ccps2022.Models
{
    public partial class Class
    {
        public int ClasseId { get; set; }
        public string NomClasse { get; set; } = null!;
        public string? Description { get; set; }
        public int NiveauClasse { get; set; }
        public string Categorie { get; set; } = null!;
    }
}

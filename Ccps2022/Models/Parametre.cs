using System;
using System.Collections.Generic;

namespace Ccps2022.Models
{
    public partial class Parametre
    {
        public int Id { get; set; }
        public string Taux { get; set; } = null!;
        public int NombreEtudiantsParClasse { get; set; }
        public decimal MontantFrais { get; set; }
        public string? Parametre17 { get; set; }
        public string? Parametre16 { get; set; }
        public string? Parametre15 { get; set; }
        public string? Parametre14 { get; set; }
        public string? Parametre13 { get; set; }
        public string? Parametre12 { get; set; }
        public string? Parametre11 { get; set; }
        public string? Parametre1 { get; set; }
    }
}

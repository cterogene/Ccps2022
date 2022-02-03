using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Ccps2022.Models
{
    public partial class Personne
    {
        [Key]
        public int PersonneId { get; set; }
        public string Prenom { get; set; } = null!;
        public string Nom { get; set; } = null!;
        public string? Telephone1 { get; set; }
        public string? Telephone2 { get; set; }
        public DateTime? Ddn { get; set; }
        public string? AdresseRue { get; set; }
        public string? AdresseExtra { get; set; }
        public string? Ville { get; set; }
        public string? Pays { get; set; }
        public DateTime DateCreee { get; set; }
        public string? Remarque { get; set; }
        public int Etudiant { get; set; }
        public int Professeur { get; set; }
        public int AdminStaff { get; set; }
        public byte[]? Photo { get; set; }
        public string? UserNameAttribue { get; set; }
        public string CreeParUsername { get; set; } = null!;
        public string? NumeroRecu { get; set; }
        public string? EtudiantIdPlus { get; set; }
        public string? Email { get; set; }
        public string? Sexe { get; set; }
    }
}

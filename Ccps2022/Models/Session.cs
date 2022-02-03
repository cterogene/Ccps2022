using System;
using System.Collections.Generic;

namespace Ccps2022.Models
{
    public partial class Session
    {
        public int SessionId { get; set; }
        public int ClasseId { get; set; }
        public int ProfesseurId { get; set; }
        public int MaxEtudiants { get; set; }
        public string JourRencontre { get; set; } = null!;
        public DateTime DateCommence { get; set; }
        public DateTime DateFin { get; set; }
        public string Heures { get; set; } = null!;
        public decimal MontantParticipation { get; set; }
        public string Byusername { get; set; } = null!;
        public int Actif { get; set; }
    }
}

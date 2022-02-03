using System;
using System.Collections.Generic;

namespace Ccps2022.Models
{
    public partial class EtudiantsCourant
    {
        public int PersonneId { get; set; }
        public int SessionId { get; set; }
        public string CreeParUsername { get; set; } = null!;
        public DateTime DateCreee { get; set; }
        public int EtudiantsCourantsId { get; set; }
        public int Admis { get; set; }
        public string? AdmisPar { get; set; }
        public int LockEdit { get; set; }
        public DateTime DateAdmis { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Ccps2022.Models
{
    public partial class DatesSessionCourante
    {
        public int SessionDateId { get; set; }
        public DateTime SessionDateDebut { get; set; }
        public DateTime SessionDateFin { get; set; }
        public string? Remarque { get; set; }
        public int Actif { get; set; }
    }
}

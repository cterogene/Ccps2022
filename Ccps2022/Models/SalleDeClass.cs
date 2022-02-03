using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Ccps2022.Models
{
    public partial class SalleDeClass
    {
        
        public int? SalleDeclasseID { get; set; } 
        public string Nom_du_salle { get; set; } = null!;
        public string? SalleDescription { get; set; }
        public int? Nombre_de_Personne { get; set; }
    }
}

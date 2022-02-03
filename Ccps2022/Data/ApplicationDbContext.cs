using Ccps2022.Models;
using Microsoft.EntityFrameworkCore;
//using MySqlX.XDevAPI;
namespace Ccps2022.Data
{
    public class ApplicationDbContext : DbContext
    {

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public ApplicationDbContext()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {

        }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {

        }


        public DbSet<JoursDeClass> JoursDeClasses { get; set; }
        public object JourDeClass { get; internal set; }
        public DbSet<SalleDeClass> SalleDeClasses { get; set; }
        public object SalleDeClass { get; internal set; }

        public DbSet<Class> Classes { get; set; }
        public object Class { get; internal set; }

        public DbSet<HeuresDeClass> HeureDeClasses { get; set; }
        public object HeureDeClass { get; internal set; }


        public DbSet<Annonce> Annonces { get; set; }
        public object Annonce { get; internal set; }

        public DbSet<DatesSessionCourante> DatesSessionCourantes { get; set; }
        public object DatesSessionCourante { get; internal set; }
        public DbSet<Personne> Personnes { get; set; }
        public object Personne { get; internal set; }


    }
}
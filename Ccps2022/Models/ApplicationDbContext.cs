using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Ccps2022.Models
{
    public partial class ApplicationDbContext : DbContext
    {
        //public ApplicationDbContext()
        //{
        //}

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Annonce> Annonces { get; set; } = null!;
        public virtual DbSet<Class> Classes { get; set; } = null!;
        public virtual DbSet<DatesSessionCourante> DatesSessionCourantes { get; set; } = null!;
        public virtual DbSet<DynamicContent> DynamicContents { get; set; } = null!;
        public virtual DbSet<EtudiantsCourant> EtudiantsCourants { get; set; } = null!;
        public virtual DbSet<Gradue> Gradues { get; set; } = null!;
        public virtual DbSet<HeuresDeClass> HeuresDeClasses { get; set; } = null!;
        public virtual DbSet<JoursDeClass> JoursDeClasses { get; set; } = null!;
        public virtual DbSet<Loan> Loans { get; set; } = null!;
        public virtual DbSet<Ministere> Ministeres { get; set; } = null!;
        public virtual DbSet<MinisteresDetail> MinisteresDetails { get; set; } = null!;
        public virtual DbSet<Parametre> Parametres { get; set; } = null!;
        public virtual DbSet<Personne> Personnes { get; set; } = null!;
        public virtual DbSet<Requisition> Requisitions { get; set; } = null!;
        public virtual DbSet<SalleDeClass> SalleDeClasses { get; set; } = null!;
        public virtual DbSet<Session> Sessions { get; set; } = null!;
        public virtual DbSet<SourcesEntree> SourcesEntrees { get; set; } = null!;
        public virtual DbSet<VEtudiantsGradue> VEtudiantsGradues { get; set; } = null!;
        public virtual DbSet<VRapportInscription> VRapportInscriptions { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LRICH; DataBase=CCPAP_Web_Edu; user id=\" ; password=\" ; Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Annonce>(entity =>
            {
                entity.Property(e => e.AnnonceId).HasColumnName("AnnonceID");

                entity.Property(e => e.Actif).HasDefaultValueSql("((1))");

                entity.Property(e => e.Annonce1)
                    .IsUnicode(false)
                    .HasColumnName("Annonce1");

                entity.Property(e => e.DateCreee)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Class>(entity =>
            {
                entity.HasKey(e => e.ClasseId);

                entity.Property(e => e.ClasseId).HasColumnName("ClasseID");

                entity.Property(e => e.Categorie).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.NomClasse).HasMaxLength(50);
            });

            modelBuilder.Entity<DatesSessionCourante>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DatesSessionCourante");

                entity.Property(e => e.Actif).HasDefaultValueSql("((1))");

                entity.Property(e => e.Remarque).HasMaxLength(50);

                entity.Property(e => e.SessionDateDebut).HasColumnType("date");

                entity.Property(e => e.SessionDateFin).HasColumnType("date");

                entity.Property(e => e.SessionDateId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SessionDateID");
            });

            modelBuilder.Entity<DynamicContent>(entity =>
            {
                entity.HasKey(e => e.ContentId)
                    .HasName("PK_dbo_DynamicContent");

                entity.ToTable("DynamicContent");

                entity.Property(e => e.ContentId).HasColumnName("ContentID");

                entity.Property(e => e.PageName).HasMaxLength(50);

                entity.Property(e => e.SectionContent).HasColumnType("ntext");

                entity.Property(e => e.SectionName).HasMaxLength(50);

                entity.Property(e => e.SiteName).HasMaxLength(50);
            });

            modelBuilder.Entity<EtudiantsCourant>(entity =>
            {
                entity.HasKey(e => e.EtudiantsCourantsId);

                entity.HasIndex(e => new { e.PersonneId, e.SessionId }, "IX_EtudiantsCourants")
                    .IsUnique();

                entity.Property(e => e.EtudiantsCourantsId).HasColumnName("EtudiantsCourantsID");

                entity.Property(e => e.AdmisPar).HasMaxLength(50);

                entity.Property(e => e.CreeParUsername).HasMaxLength(50);

                entity.Property(e => e.DateAdmis)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateCreee)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PersonneId).HasColumnName("PersonneID");

                entity.Property(e => e.SessionId).HasColumnName("SessionID");
            });

            modelBuilder.Entity<Gradue>(entity =>
            {
                entity.Property(e => e.GradueId).HasColumnName("GradueID");

                entity.Property(e => e.DateGraduation).HasColumnType("date");

                entity.Property(e => e.DateImprime)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PersonneId).HasColumnName("PersonneID");

                entity.Property(e => e.Sujet).HasMaxLength(50);
            });

            modelBuilder.Entity<HeuresDeClass>(entity =>
            {
                entity.HasKey(e => e.HeureID);

                entity.Property(e => e.HeureID).HasColumnName("HeureID");

                entity.Property(e => e.Categorie).HasMaxLength(50);

                entity.Property(e => e.HeureDescription).HasMaxLength(50);
            });

            modelBuilder.Entity<JoursDeClass>(entity =>
            {
                entity.HasKey(e => e.JourId);

                entity.Property(e => e.JourId).HasColumnName("JourID");

                entity.Property(e => e.JourDescription).HasMaxLength(50);
            });

            modelBuilder.Entity<Loan>(entity =>
            {
                entity.Property(e => e.LoanId).HasColumnName("LoanID");

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.Identification).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Remarks).HasMaxLength(50);
            });

            modelBuilder.Entity<Ministere>(entity =>
            {
                entity.Property(e => e.MinistereId).HasColumnName("MinistereID");

                entity.Property(e => e.IsActif).HasDefaultValueSql("((1))");

                entity.Property(e => e.MinistereNom).HasMaxLength(50);
            });

            modelBuilder.Entity<MinisteresDetail>(entity =>
            {
                entity.HasKey(e => e.MinistereDetailId)
                    .HasName("PK_Ministeres");

                entity.Property(e => e.MinistereDetailId).HasColumnName("MinistereDetailID");

                entity.Property(e => e.MinistereId).HasColumnName("MinistereID");

                entity.Property(e => e.NomMinistere).HasMaxLength(50);
            });

            modelBuilder.Entity<Parametre>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MontantFrais).HasColumnType("smallmoney");

                entity.Property(e => e.Parametre1).HasMaxLength(50);

                entity.Property(e => e.Parametre11).HasMaxLength(50);

                entity.Property(e => e.Parametre12).HasMaxLength(50);

                entity.Property(e => e.Parametre13).HasMaxLength(50);

                entity.Property(e => e.Parametre14).HasMaxLength(50);

                entity.Property(e => e.Parametre15).HasMaxLength(50);

                entity.Property(e => e.Parametre16).HasMaxLength(50);

                entity.Property(e => e.Parametre17).HasMaxLength(50);

                entity.Property(e => e.Taux).HasMaxLength(150);
            });

            modelBuilder.Entity<Personne>(entity =>
            {
                entity.HasIndex(e => new { e.Nom, e.Prenom, e.Ddn }, "IX_Personnes")
                    .IsUnique();

                entity.Property(e => e.PersonneId).HasColumnName("PersonneID");

                entity.Property(e => e.AdresseExtra).HasMaxLength(50);

                entity.Property(e => e.AdresseRue).HasMaxLength(50);

                entity.Property(e => e.CreeParUsername).HasMaxLength(50);

                entity.Property(e => e.DateCreee)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ddn)
                    .HasColumnType("date")
                    .HasColumnName("DDN");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.EtudiantIdPlus).HasMaxLength(50);

                entity.Property(e => e.Nom).HasMaxLength(50);

                entity.Property(e => e.NumeroRecu).HasMaxLength(50);

                entity.Property(e => e.Pays)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'Haiti')");

                entity.Property(e => e.Prenom).HasMaxLength(50);

                entity.Property(e => e.Remarque).HasMaxLength(150);

                entity.Property(e => e.Sexe)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Telephone1).HasMaxLength(50);

                entity.Property(e => e.Telephone2).HasMaxLength(50);

                entity.Property(e => e.UserNameAttribue).HasMaxLength(50);

                entity.Property(e => e.Ville).HasMaxLength(50);
            });

            modelBuilder.Entity<Requisition>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ApprovedBy).HasMaxLength(50);

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.Justification).HasMaxLength(50);

                entity.Property(e => e.Memo).HasMaxLength(50);

                entity.Property(e => e.PayTo).HasMaxLength(50);

                entity.Property(e => e.ReqAmount).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ReqDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReqId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ReqID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<SalleDeClass>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Nom_du_salle)
                    .HasMaxLength(50)
                    .HasColumnName("Nom_du_salle");

                entity.Property(e => e.Nombre_de_Personne).HasColumnName("Nombre_de_Personne");

                entity.Property(e => e.SalleDeclasseID).HasColumnName("SalleDeclasseID");
            });

            modelBuilder.Entity<Session>(entity =>
            {
                entity.HasIndex(e => new { e.ClasseId, e.DateCommence, e.DateFin, e.Heures, e.JourRencontre }, "IX_Sessions");

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.Actif)
                    .HasColumnName("actif")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Byusername)
                    .HasMaxLength(50)
                    .HasColumnName("byusername");

                entity.Property(e => e.ClasseId).HasColumnName("ClasseID");

                entity.Property(e => e.DateCommence).HasColumnType("date");

                entity.Property(e => e.DateFin).HasColumnType("date");

                entity.Property(e => e.Heures).HasMaxLength(50);

                entity.Property(e => e.JourRencontre).HasMaxLength(50);

                entity.Property(e => e.MontantParticipation).HasColumnType("money");

                entity.Property(e => e.ProfesseurId).HasColumnName("ProfesseurID");
            });

            modelBuilder.Entity<SourcesEntree>(entity =>
            {
                entity.HasKey(e => e.SourceId)
                    .HasName("PK_SourceEntrees");

                entity.Property(e => e.SourceId).HasColumnName("SourceID");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Monnaie).HasMaxLength(50);

                entity.Property(e => e.NomSource).HasMaxLength(50);
            });

            modelBuilder.Entity<VEtudiantsGradue>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vEtudiantsGradues");

                entity.Property(e => e.Nom).HasMaxLength(50);

                entity.Property(e => e.PersonneId).HasColumnName("PersonneID");

                entity.Property(e => e.Prenom).HasMaxLength(50);
            });

            modelBuilder.Entity<VRapportInscription>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vRapportInscriptions");

                entity.Property(e => e.CreeParUsername).HasMaxLength(50);

                entity.Property(e => e.NomClasse).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
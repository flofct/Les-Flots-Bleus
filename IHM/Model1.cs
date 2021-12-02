using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace IHM
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<course> course { get; set; }
        public virtual DbSet<employe> employe { get; set; }
        public virtual DbSet<entreprise> entreprise { get; set; }
        public virtual DbSet<epreuve> epreuve { get; set; }
        public virtual DbSet<marin> marin { get; set; }
        public virtual DbSet<voilier> voilier { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<course>()
                .Property(e => e.nom_course)
                .IsUnicode(false);

            modelBuilder.Entity<course>()
                .Property(e => e.localisaiton_course)
                .IsUnicode(false);

            modelBuilder.Entity<employe>()
                .Property(e => e.nom_employe)
                .IsUnicode(false);

            modelBuilder.Entity<employe>()
                .Property(e => e.prenom_employe)
                .IsUnicode(false);

            modelBuilder.Entity<employe>()
                .Property(e => e.role_employe)
                .IsUnicode(false);

            modelBuilder.Entity<employe>()
                .Property(e => e.identifiant_employe)
                .IsUnicode(false);

            modelBuilder.Entity<employe>()
                .Property(e => e.mdp_employe)
                .IsUnicode(false);

            modelBuilder.Entity<employe>()
                .Property(e => e.mail_employe)
                .IsUnicode(false);

            modelBuilder.Entity<entreprise>()
                .Property(e => e.nom_entreprise)
                .IsUnicode(false);

            modelBuilder.Entity<entreprise>()
                .Property(e => e.domaine_entreprise)
                .IsUnicode(false);

            modelBuilder.Entity<entreprise>()
                .Property(e => e.SS_entreprise)
                .IsUnicode(false);

            modelBuilder.Entity<entreprise>()
                .Property(e => e.mail_entreprise)
                .IsUnicode(false);

            modelBuilder.Entity<entreprise>()
                .Property(e => e.nomContact_entreprise)
                .IsUnicode(false);

            modelBuilder.Entity<entreprise>()
                .Property(e => e.prenomContact_entreprise)
                .IsUnicode(false);

            modelBuilder.Entity<epreuve>()
                .Property(e => e.nom_epreuve)
                .IsUnicode(false);

            modelBuilder.Entity<marin>()
                .Property(e => e.nom_marin)
                .IsUnicode(false);

            modelBuilder.Entity<marin>()
                .Property(e => e.prenom_marin)
                .IsUnicode(false);

            modelBuilder.Entity<marin>()
                .Property(e => e.ville_marin)
                .IsUnicode(false);

            modelBuilder.Entity<marin>()
                .Property(e => e.adresse_marin)
                .IsUnicode(false);

            modelBuilder.Entity<marin>()
                .Property(e => e.mail_marin)
                .IsUnicode(false);

            modelBuilder.Entity<marin>()
                .Property(e => e.role_marin)
                .IsUnicode(false);

            modelBuilder.Entity<voilier>()
                .Property(e => e.nom_voilier)
                .IsUnicode(false);

            modelBuilder.Entity<voilier>()
                .Property(e => e.materiaux_voilier)
                .IsUnicode(false);
        }
    }
}

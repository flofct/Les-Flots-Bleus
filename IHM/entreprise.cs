namespace IHM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("flotsbleus.entreprise")]
    public partial class entreprise
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_entreprise { get; set; }

        [Required]
        [StringLength(100)]
        public string nom_entreprise { get; set; }

        [Required]
        [StringLength(100)]
        public string domaine_entreprise { get; set; }

        [Required]
        [StringLength(100)]
        public string SS_entreprise { get; set; }

        [Required]
        [StringLength(100)]
        public string mail_entreprise { get; set; }

        public int tel_entreprise { get; set; }

        [Required]
        [StringLength(100)]
        public string nomContact_entreprise { get; set; }

        [Required]
        [StringLength(100)]
        public string prenomContact_entreprise { get; set; }

        public int idVoilierInscrit_entreprise { get; set; }

        public double budget_entreprise { get; set; }

        public int nombreParticipation_entreprise { get; set; }
    }
}

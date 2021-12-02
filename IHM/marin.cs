namespace IHM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("flotsbleus.marin")]
    public partial class marin
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_marin { get; set; }

        [Required]
        [StringLength(100)]
        public string nom_marin { get; set; }

        [Required]
        [StringLength(100)]
        public string prenom_marin { get; set; }

        [Column(TypeName = "date")]
        public DateTime dateNaissance_marin { get; set; }

        [Required]
        [StringLength(100)]
        public string ville_marin { get; set; }

        public int cp_marin { get; set; }

        [Required]
        [StringLength(100)]
        public string adresse_marin { get; set; }

        [Required]
        [StringLength(100)]
        public string mail_marin { get; set; }

        public int tel_marin { get; set; }

        public int idVoilierInscrit_marin { get; set; }

        [Required]
        [StringLength(100)]
        public string role_marin { get; set; }
    }
}

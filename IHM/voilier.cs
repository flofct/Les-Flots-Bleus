namespace IHM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("flotsbleus.voilier")]
    public partial class voilier
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_voilier { get; set; }

        [Required]
        [StringLength(100)]
        public string nom_voilier { get; set; }

        public double longueur_voilier { get; set; }

        public double largeur_voilier { get; set; }

        [Required]
        [StringLength(100)]
        public string materiaux_voilier { get; set; }

        public double poids_voilier { get; set; }
    }
}

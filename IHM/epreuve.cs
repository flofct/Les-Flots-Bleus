namespace IHM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("flotsbleus.epreuve")]
    public partial class epreuve
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_epreuve { get; set; }

        [Required]
        [StringLength(100)]
        public string nom_epreuve { get; set; }

        public double longueur_epreuve { get; set; }

        public int idCourse_epreuve { get; set; }
    }
}

namespace IHM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("flotsbleus.course")]
    public partial class course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_course { get; set; }

        [Required]
        [StringLength(100)]
        public string nom_course { get; set; }

        public double longueur_course { get; set; }

        [Required]
        [StringLength(100)]
        public string localisaiton_course { get; set; }

        [Column(TypeName = "date")]
        public DateTime date_course { get; set; }

        public TimeSpan heure_course { get; set; }
    }
}

namespace IHM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("flotsbleus.employe")]
    public partial class employe
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_employe { get; set; }

        [Required]
        [StringLength(50)]
        public string nom_employe { get; set; }

        [Required]
        [StringLength(50)]
        public string prenom_employe { get; set; }

        [Required]
        [StringLength(100)]
        public string role_employe { get; set; }

        [Required]
        [StringLength(100)]
        public string identifiant_employe { get; set; }

        [Required]
        [StringLength(100)]
        public string mdp_employe { get; set; }

        [Required]
        [StringLength(100)]
        public string mail_employe { get; set; }
    }
}

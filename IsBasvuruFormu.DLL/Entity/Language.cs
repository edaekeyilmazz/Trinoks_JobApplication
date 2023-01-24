namespace IsBasvuruFormu.DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Language")]
    public partial class Language
    {
        [Key]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [StringLength(50)]
        public string Understanding { get; set; }

        [StringLength(50)]
        public string Speaking { get; set; }

        [StringLength(50)]
        public string Writing { get; set; }

        [StringLength(50)]
        public string LearnedWhere { get; set; }

        [StringLength(50)]
        public string AbroadExperience { get; set; }

        [StringLength(50)]
        public string ExperienceTime { get; set; }

        public int PersonID { get; set; }

        public virtual Person Person { get; set; }
    }
}

namespace IsBasvuruFormu.DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OtherEducation")]
    public partial class OtherEducation
    {
        [Key]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [StringLength(50)]
        public string EName { get; set; }

        [StringLength(50)]
        public string Institution { get; set; }

        [StringLength(50)]
        public string StartDate { get; set; }

        [StringLength(50)]
        public string EndDate { get; set; }

        public bool? Certificate { get; set; }

        public int PersonID { get; set; }

        public virtual Person Person { get; set; }
    }
}

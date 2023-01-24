namespace IsBasvuruFormu.DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WorkExperience")]
    public partial class WorkExperience
    {
        [Key]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [StringLength(50)]
        public string Company { get; set; }

        [StringLength(50)]
        public string Position { get; set; }

        public decimal? Salary { get; set; }

        [StringLength(50)]
        public string BeginDate { get; set; }

        [StringLength(50)]
        public string EndDate { get; set; }

        [StringLength(50)]
        public string ExitReason { get; set; }

        public int PersonID { get; set; }

        public virtual Person Person { get; set; }
    }
}

namespace IsBasvuruFormu.DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Contact")]
    public partial class Contact
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int ID { get; set; }

        [DisplayName("Address")]
        [Column(Order = 1)]
        [StringLength(50)]
        [Required(ErrorMessage = "Adres bilgisi boþ býrakýlamaz")]
        public string Address { get; set; }


        [Column(Order = 2)]
        [StringLength(50)]
        [Required(ErrorMessage = "Þehir bilgisi boþ býrakýlamaz")]
        public string City { get; set; }

        [Column(Order = 3)]
        [StringLength(50)]
        public string Phone { get; set; }

        [Column(Order = 4)]
        [StringLength(50)]
        public string GSM { get; set; }

        [Column(Order = 5)]
        [Required(ErrorMessage = "Sürücü belgesi bilgisi giriniz")]
        public bool DriverLicense { get; set; }

        [StringLength(50)]
        public string DriverClass { get; set; }

        [StringLength(50)]
        public string TrafficExperience { get; set; }

        [Column(Order = 6)]
        [StringLength(50)]
        public string Dependent { get; set; }

        [Column(Order = 7)]
        [StringLength(50)]
        [Required(ErrorMessage = "Varsa saðlýk problemlerinizi yazýnýz.")]
        public string HealthIssue { get; set; }

        [Column(Order = 8)]
        [StringLength(50)]
        [Required(ErrorMessage = "Lütfen geçirdiðiniz saðlýk problemlerinizi giriniz.")]
        public string SeriousIllness { get; set; }

        [Column(Order = 9)]
        [StringLength(50)]
        [Required(ErrorMessage = "Lütfen sicilinizde suç hükmü bulunup bulunmadýðýný belirtiniz.")]
        public string Registry { get; set; }

        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PersonID { get; set; }

         [Column(Order = 11)]
         [StringLength(50)]
         [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                            @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                            @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
                            ErrorMessage = "Lütfen geçerli bir e-mail adresi giriniz.")]
        public string EMail { get; set; }

        [Column(Order = 12)]
         public bool Trip { get; set; }

        public virtual Person Person { get; set; }
    }
}

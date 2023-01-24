namespace IsBasvuruFormu.DLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Person")]
    public partial class Person
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Person()
        {
            Educations = new HashSet<Education>();
            Languages = new HashSet<Language>();
            OtherEducations = new HashSet<OtherEducation>();
            Contacts = new HashSet<Contact>();
            References = new HashSet<Reference>();
            WorkExperiences = new HashSet<WorkExperience>();
        }

        [Key]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Lütfen adýnýzý giriniz.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen cinsiyetinizi belirtiniz.")]
        public bool Gender { get; set; }

        [Required(ErrorMessage = "Lütfen medeni hal bilgisi giriniz.")]
        public bool MaritalStatus { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Lütfen doðum yerinizi belirtiniz.")]
        public string BirthPlace { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Lütfen doðum tarihinizi belirtiniz.")]
        public string BirthDate { get; set; }

        public bool Smoking { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Lütfen baba adý, soyadý ve mesleðini belirtiniz.")]
        public string FatherName { get; set; }
        public byte Military { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Lütfen baþvurmak istediðiniz pozistonu belirtiniz.")]
        public string ReferencedPosition { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Lütfen iþe baþlayabileceðiniz tarihi belirtiniz.")]        
        public string EstimatedStartingDate { get; set; }

        [Required(ErrorMessage = "Lütfen talep ettiðiniz aylýk net maaþ bilgisini giriniz.")]
        public decimal RequestedFee { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Lütfen talep ettiðiniz yan haklarý giriniz.")]
        public string Benefit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Education> Educations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Language> Languages { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OtherEducation> OtherEducations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contact> Contacts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reference> References { get; set; }
        
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkExperience> WorkExperiences { get; set; }
    }
}

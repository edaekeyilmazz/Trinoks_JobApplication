namespace IsBasvuruFormu.DLL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class IsBasvuruContext : DbContext
    {
        public IsBasvuruContext()
            : base("name=IsBasvuruContext")
        {
        }

        public virtual DbSet<Education> Educations { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<OtherEducation> OtherEducations { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<WorkExperience> WorkExperiences { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Reference> References { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
                .HasMany(e => e.WorkExperiences)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.Educations)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.Languages)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.OtherEducations)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.Contacts)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.References)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Contact>()
                .Property(e => e.GSM)
                .IsFixedLength();

            modelBuilder.Entity<Contact>()
                .Property(e => e.TrafficExperience)
                .IsFixedLength();
        }
    }
}

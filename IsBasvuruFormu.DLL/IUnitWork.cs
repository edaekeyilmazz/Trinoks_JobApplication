using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsBasvuruFormu.DLL.Repositories
{
    public interface IUnitWork
    {   
        IGenericRepository<Person> personRep { get; }
        IGenericRepository<Contact> contactRep { get;  }
        IGenericRepository<Education> educationRep { get; }
        IGenericRepository<OtherEducation> otherEducationRep { get; }
        IGenericRepository<Language> languageRep { get; }
        IGenericRepository<WorkExperience> workExperienceRep { get; }
        IGenericRepository<Reference> referenceRep { get; }
        
        Task<bool> SaveChanges();
    }
}

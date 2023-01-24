using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsBasvuruFormu.DLL.Repositories
{
    public class UnitOfWork: IUnitWork, IDisposable
    {
        IsBasvuruContext context;
        public UnitOfWork()
        {
            context = new IsBasvuruContext();
        }


        PersonRepository _personRep;
        public IGenericRepository<Person> personRep
        {
            get
            {
                if (_personRep == null)
                    _personRep = new PersonRepository(context);
                return _personRep;
            }
        }

        ContactRepository _contactRep;
        public IGenericRepository<Contact> contactRep
        {
            get
            {
                if (_contactRep == null)
                    _contactRep = new ContactRepository(context);
                return _contactRep;
            }
        }

        EducationRepository _educationRep;
        public IGenericRepository<Education> educationRep
        {
            get
            {
                if (_educationRep == null)
                    _educationRep = new EducationRepository(context);
                return _educationRep;
            }
        }

        OtherEducationRepository _otherEducationRep;
        public IGenericRepository<OtherEducation> otherEducationRep
        {
            get
            {
                if (_otherEducationRep == null)
                    _otherEducationRep = new OtherEducationRepository(context);
                return _otherEducationRep;
            }
        }

        LanguageRepository _languageRep;
        public IGenericRepository<Language> languageRep
        {
            get
            {
                if (_languageRep == null)
                    _languageRep = new LanguageRepository(context);
                return _languageRep;
            }
        }

        WorkExperienceRepository _workExperienceRep;
        public IGenericRepository<WorkExperience> workExperienceRep
        {
            get
            {
                if (_workExperienceRep == null)
                    _workExperienceRep = new WorkExperienceRepository(context);
                return _workExperienceRep;
            }
        }

        ReferenceRepository _referenceRep;
        public IGenericRepository<Reference> referenceRep
        {
            get
            {
                if (_referenceRep == null)
                    _referenceRep = new ReferenceRepository(context);
                return _referenceRep;
            }
        }


        public void Dispose()
        {
            throw new NotImplementedException();
        }


        public async Task<bool> SaveChanges()
        {
            return (await context.SaveChangesAsync() > 0);
        }
    }
}

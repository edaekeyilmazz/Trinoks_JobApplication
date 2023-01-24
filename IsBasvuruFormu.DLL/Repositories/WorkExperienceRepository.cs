using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IsBasvuruFormu.DLL.Repositories
{
    public class WorkExperienceRepository : GenericRepository<WorkExperience>
    {
        public WorkExperienceRepository(IsBasvuruContext _context)
            : base(_context)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IsBasvuruFormu.DLL.Repositories
{
    public class EducationRepository: GenericRepository<Education>
    {
        public EducationRepository(IsBasvuruContext _context)
            : base(_context)
        {

        }
    }
}

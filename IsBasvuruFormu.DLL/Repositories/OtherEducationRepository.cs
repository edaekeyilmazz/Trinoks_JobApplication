using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IsBasvuruFormu.DLL.Repositories
{
    public class OtherEducationRepository: GenericRepository<OtherEducation>
    {
        public OtherEducationRepository(IsBasvuruContext _context)
            : base(_context)
        {

        }
    }
}

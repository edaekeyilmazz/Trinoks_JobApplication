using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IsBasvuruFormu.DLL.Repositories
{
    public class ReferenceRepository: GenericRepository<Reference>
    {
        public ReferenceRepository(IsBasvuruContext _context) : base(_context)
        {

        }
    }
}

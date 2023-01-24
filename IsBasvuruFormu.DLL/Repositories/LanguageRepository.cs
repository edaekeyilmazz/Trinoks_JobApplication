using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IsBasvuruFormu.DLL.Repositories
{
    public class LanguageRepository: GenericRepository<Language>
    {
        public LanguageRepository(IsBasvuruContext _context)
            : base(_context)
        {

        }
    }
}

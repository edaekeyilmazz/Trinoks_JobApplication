using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IsBasvuruFormu.DLL.Repositories
{
    public class ContactRepository: GenericRepository<Contact>
    {
        public ContactRepository(IsBasvuruContext _context)
            : base(_context)
        {

        }
    }
}

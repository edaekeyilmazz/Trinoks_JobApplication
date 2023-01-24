using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IsBasvuruFormu.DLL.Repositories
{
    public class PersonRepository: GenericRepository<Person>
    {
        public PersonRepository(IsBasvuruContext _context)
            : base(_context)
        {

        }
    }
}

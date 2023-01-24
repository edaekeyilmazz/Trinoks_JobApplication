using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IsBasvuruFormu.DLL.Repositories
{
    public interface IGenericRepository<T> 
        where T : class
    {
        void Insert(T ent);
    }
}

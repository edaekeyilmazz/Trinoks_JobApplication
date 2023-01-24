 using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsBasvuruFormu.DLL.Repositories
{
    public class GenericRepository<T>: IGenericRepository<T>
        where T:class
    {
        protected IsBasvuruContext  _context;
        protected DbSet<T> db;
        public GenericRepository(IsBasvuruContext context)
        {
            this._context = context;
            db = context.Set<T>();
        }
        public void Insert(T ent)
        {
            db.Add(ent);
            _context.Entry<T>(ent).State = EntityState.Added;
        }
    }
}

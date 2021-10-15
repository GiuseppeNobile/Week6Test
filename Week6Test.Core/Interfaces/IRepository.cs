using System;
using System.Collections.Generic;
using System.Text;

namespace Week6Test.Core.Interfaces
{
    public interface IRepository<TEntity>
    {
        List<TEntity> Fetch(Func<TEntity, bool> filter = null);        
        bool Add(TEntity item);
        bool Update(TEntity item);
        bool Delete(TEntity item);
    }
}
